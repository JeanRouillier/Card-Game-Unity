using UnityEngine;
using UnityEngine.EventSystems;


public class CurrentPath : Dragable
{
    private MetaGameManager manager;

    public GameObject lowerLeftpath;
    public GameObject upperRightpath;
    public GameObject lowerRightOnepath;
    public GameObject lowerRightTwoPath;
    public GameObject upperLeftpath;

    private void Start()
    {
        manager = MetaGameManager._instance;

    }

    new void OnTriggerStay2D(Collider2D collision){
        base.OnTriggerStay2D(collision);
        updateSelectedPath(collision);
    }


    private void updateSelectedPath(Collider2D collision)
    {
        if (collision.gameObject == lowerLeftpath)
        {
            manager.setCurrentPath(CampaignPathEnum.LOWER_LEFT);
        }
        else if(collision.gameObject == upperRightpath)
        {
            manager.setCurrentPath(CampaignPathEnum.UPPER_RIGHT);
        }
        else if (collision.gameObject == lowerRightOnepath)
        {
            manager.setCurrentPath(CampaignPathEnum.LOWER_RIGHT_ONE);
        }
        else if (collision.gameObject == lowerRightTwoPath)
        {
            manager.setCurrentPath(CampaignPathEnum.LOWER_RIGHT_TWO);
        }
        else if (collision.gameObject == upperLeftpath)
        {
            manager.setCurrentPath(CampaignPathEnum.UPPER_LEFT);
        }
    }

}

