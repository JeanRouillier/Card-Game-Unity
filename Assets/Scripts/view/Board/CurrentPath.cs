using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentPath : MonoBehaviour
{
    private MetaGameManager manager;

    private float startX;
    private float startY;
    private bool isDraged = false;

    public Color hoverColor;
    public Color defaultColor;

    public GameObject lowerLeftpath;
    public GameObject upperRightpath;
    public GameObject lowerRightOnepath;
    public GameObject lowerRightTwoPath;
    public GameObject upperLeftpath;

    private void Start()
    {
        manager = MetaGameManager._instance;

    }
    void Update()
    {
        if (isDraged)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.localPosition = new Vector3(mousePosition.x - startX, mousePosition.y - startY, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            isDraged = true;
            startX = mousePosition.x - transform.localPosition.x;
            startY = mousePosition.y - transform.localPosition.y;
        }        
    }

    private void OnMouseUp()
    {
        isDraged = false;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (isDraged && collision.gameObject.tag == "CampaignPath")
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = hoverColor;
        }
        else {
            updateSelectedPath(collision);
        }

        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Out");
        if(collision.gameObject.tag == "CampaignPath"){
            collision.gameObject.GetComponent<SpriteRenderer>().color = defaultColor;
        }
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

