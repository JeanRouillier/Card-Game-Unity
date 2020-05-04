using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBoard : MonoBehaviour
{
    private MetaGameManager manager;
   
    public EnemiesBoardUI enemiesBoardUI;
    public AlliesWaitingZone alliesWaitingZone;
    public GameObject campaignBoardObject;

    public Sprite wolnirCampaign;
    public Sprite sulyvanCampaign;

    public Text currentStepText;
    public Text currentStepButtonText;


    // Start is called before the first frame update
    void Start()
    {
        manager =MetaGameManager._instance;
        Sprite campaignImage = manager.game.campaignPath.chosenPath.id == CampaignsId.WOLNIR ? wolnirCampaign : sulyvanCampaign;
        campaignBoardObject.GetComponent<SpriteRenderer>().sprite = campaignImage;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void nextStep()
    {
        RoundState activeStep = manager.nextStep();
        switch (activeStep)
        {
            case RoundState.START:
                currentStepText.text = "Chose a your next path by moving the token onto it";
                currentStepButtonText.text = "Valid path";
                break;
            case RoundState.ENCOUNTER_PICKED:
                currentStepText.text = "An encounter have been picked. According to the number of players, enemies have been picked and placed on board. Position your characters on your board";
                currentStepButtonText.text = "Validate position";
                break;
            case RoundState.ALLIES_PLACED:
                currentStepText.text = "All enemies will attack according to their card description, prepare to defend !";
                currentStepButtonText.text = "Defend";
                displayAttacks();
                break;
            case RoundState.ENEMIES_ATTACKED:
                currentStepText.text = "It is now your time to attack";
                currentStepButtonText.text = "Attack target";
                break;
        }

    }

    private void displayAttacks(){
        Round r = manager.getCurrentRound();
        EnemyAttack attack = manager.GetEnemyService()
                                .attack(r.nbEnemiesAttacked, manager.GetEnemiesBoard(), manager.GetAlliesBoard());
        Enemy e = attack.attacker;
        List<Player> defenderd = attack.targets;
        foreach(Player p in defenderd){
            GameObject playerGo = alliesWaitingZone.getGameObjectFromPlayerType(p);
            GameObject enemyGo = enemiesBoardUI.getEnemyGameObject(e);
            if(playerGo != null  && enemyGo != null){
                GlobalHelper.drawArrow(enemyGo, playerGo);
            }
        }
    }
}
