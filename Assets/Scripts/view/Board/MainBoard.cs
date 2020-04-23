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

    // Start is called before the first frame update
    void Start()
    {
        manager =MetaGameManager._instance;
        Sprite campaignImage = manager.game.campaignPath.chosenPath.id == CampaignsId.WOLNIR ? wolnirCampaign : sulyvanCampaign;
        campaignBoardObject.GetComponent<Image>().sprite = campaignImage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
