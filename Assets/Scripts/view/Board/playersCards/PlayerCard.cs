using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCard : MonoBehaviour
{
    private float startX;
    private float startY;
    private bool isDraged = false;

    public Color hoverColor;
    public Color defaultColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        if (isDraged && collision.gameObject.tag =="PlayerPosition")
        {
            Debug.Log("this "+ transform.position);
            Debug.Log("collide "+ collision.transform.position);
            collision.gameObject.GetComponent<SpriteRenderer>().color = hoverColor;
            transform.position = collision.transform.position;
            transform.rotation = collision.transform.rotation;
        }
               
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
         if(collision.gameObject.tag =="PlayerPosition"){
            collision.gameObject.GetComponent<SpriteRenderer>().color = defaultColor;
            transform.rotation = new Quaternion();
         }
    }

    private void placePlayer(Collider2D c){
        
    }
}
