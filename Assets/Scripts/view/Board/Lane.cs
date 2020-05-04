using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class Lane : MonoBehaviour
{
    private MetaGameManager manager;

    public GameObject zero;
    public GameObject one;
    public GameObject two;

    public string tagToInteractWith;
    public bool isFrontLane = true;

    // Start is called before the first frame update
    void Start(){
        manager = MetaGameManager._instance;
    }
  
    public void renderContent(List<Enemy> placed, SpriteAtlas atlas){
        foreach(Person p in placed){
            GameObject o = getEnemyGameObjectByposition(p.position);
            if(o != null){
                o.GetComponent<SpriteRenderer>().sprite = atlas.GetSprite(p.textureName);
            }
        }
    }

    public GameObject getEnemyGameObjectByposition(BoardPosition position){
        int y = position.y;
            GameObject o = null;
            if(y == 0){
               o =  zero;
            }
            if(y == 1){
                o =  one;
            }
            if(y == 2){
                o =  two;
            }
            return o;
    }
}
