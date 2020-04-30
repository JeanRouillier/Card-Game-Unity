using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClassCard : Dragable
{
    private MetaGameManager manager;
    public PlayersAvailable type;

    void Start(){
        manager = MetaGameManager._instance;
    }

    new void OnTriggerStay2D(Collider2D collision){
        base.OnTriggerStay2D(collision);
        if(collision.gameObject.tag == tagToInteractWith){
            int x = collision.gameObject.GetComponent<BoardPositionUI>().x;
            int y = collision.gameObject.GetComponent<BoardPositionUI>().y;
            Player pl = manager.getActivePlayers().Find( p => p.type == type);
            bool canPlace = manager.GetAlliesBoard().setAtPosition(new BoardPosition(x, y), pl);
        }

    }

    new void OnTriggerExit2D(Collider2D collision){
        base.OnTriggerExit2D(collision);
        if(collision.gameObject.tag == tagToInteractWith){
            int x = collision.gameObject.GetComponent<BoardPositionUI>().x;
            int y = collision.gameObject.GetComponent<BoardPositionUI>().y;
            Player pl = manager.getActivePlayers().Find( p => p.type == type);
            bool canPlace = manager.GetAlliesBoard().setAtPosition(null, pl);
        }


    }

}
