using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class MetaGameManager : MonoBehaviour
{
    public int activePlayers { get; set; }
    public HashSet<PlayersAvailable> pickedPlayerd = new HashSet<PlayersAvailable>();
    public CardGame game = new CardGame();

    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }

	public void Quit()
	{
		Application.Quit();
	}
	public void initActivePlayers(HashSet<PlayersAvailable> list)
	{
		game.players.InitActivePlayers(list);
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
}
