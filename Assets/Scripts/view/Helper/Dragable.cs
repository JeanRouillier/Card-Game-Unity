using UnityEngine;
using UnityEngine.EventSystems;


public class Dragable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private float startX;
    private float startY;
    private Vector3 initialPosition;
    private Quaternion initialQuaternion;
    private Vector3 collidedWithPosition;
    private Quaternion collidedWithQuaternion;

    public Color hoverColor;
    public Color defaultColor;
    
    public string tagToInteractWith;
    
    void Awake(){
        initialPosition = gameObject.transform.position;
        initialQuaternion = gameObject.transform.rotation;
    }
    protected void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == tagToInteractWith)
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = hoverColor;
            collidedWithPosition = collision.transform.position;
            collidedWithQuaternion =  collision.transform.rotation;
        }
    }

    protected void OnTriggerExit2D(Collider2D collision)
    {
         if(collision.gameObject.tag == tagToInteractWith){
            collision.gameObject.GetComponent<SpriteRenderer>().color = defaultColor;
              collidedWithPosition = initialPosition;
              collidedWithQuaternion = new Quaternion();
           }
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.localPosition = new Vector3(mousePosition.x - startX, mousePosition.y - startY, 0);
    }

    public void OnBeginDrag(PointerEventData eventData){
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        startX = mousePosition.x - transform.localPosition.x;
        startY = mousePosition.y - transform.localPosition.y;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(collidedWithPosition != new Vector3()){
            transform.position  = collidedWithPosition;
            transform.rotation = collidedWithQuaternion;
        }
    }
}
