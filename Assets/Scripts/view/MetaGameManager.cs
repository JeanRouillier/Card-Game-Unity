using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.SceneManagement;


public class MetaGameManager : MonoBehaviour
{
	public static MetaGameManager _instance ;
	public int activePlayers { get; set; }
    public HashSet<PlayersAvailable> pickedPlayerd = new HashSet<PlayersAvailable>();
    public CardGame game = new CardGame();

	void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
			Destroy(gameObject);
	}

	public void Quit()
	{
		Application.Quit();
	}
	public void initActivePlayers(HashSet<PlayersAvailable> list)
	{
		game.players.InitActivePlayers(list);
	}

	public List<Player> getActivePlayers(){
		return game.players.activePlayers;
	}

	public void initPickedCampaign(int campaignId)
	{
		if (campaignId == 0)
		{
			game.campaignPath.chosenPath = game.campaignPath.wolnirCampaign;
		}
		else if (campaignId == 1)
		{
			game.campaignPath.chosenPath = game.campaignPath.sulyvanCampaign;
		}
	}

	public RoundState nextStep()
	{
		game.nextStep();
		return game.currentRound.state;
	}

	public CampaignPath setCurrentPath(CampaignPathEnum s)
	{
		CampaignPath newPath = null;
		switch (s)
		{
			case CampaignPathEnum.LOWER_LEFT:
				newPath = game.campaignPath.chosenPath.lowerLeft ;
				break;
			case CampaignPathEnum.UPPER_RIGHT:
				newPath = game.campaignPath.chosenPath.upperRight;
				break;
			case CampaignPathEnum.LOWER_RIGHT_ONE:
				newPath = game.campaignPath.chosenPath.lowerRight;
				break;
			case CampaignPathEnum.LOWER_RIGHT_TWO:
				newPath = game.campaignPath.chosenPath.lowerRight.next;
				break;
			case CampaignPathEnum.UPPER_LEFT:
				newPath = game.campaignPath.chosenPath.upperLeft;
				break;
		}
		game.campaignPath.currentPath = newPath;
		game.campaignPath.currentPath.position = s;
		return newPath;
	}
	
	public Round getCurrentRound()
	{
		return game.currentRound;
	}

	public CampaignPath getCurrentPath()
	{
		return game.campaignPath.currentPath;
	}

	public EnemiesBoard GetEnemiesBoard(){
		return game.enemiesBoard;
	}
	
	public AlliesBoard GetAlliesBoard(){
		return game.alliesBoard;
	}

}
