using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainBoard : MonoBehaviour
{
    private MetaGameManager manager;
   
    public GameObject enemiesBoardObject;
    public GameObject alliesBoardObject;
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
            case RoundState.PICK_PATH:
                currentStepText.text = "Pick encounter";
                currentStepButtonText.text = "Valid encounter";
                break;
            case RoundState.ENCOUNTER_PICKED:
                currentStepText.text = "Enemies are placed on board. Position your characters on your board";
                currentStepButtonText.text = "Validate position";
                break;
        }
    }
}
