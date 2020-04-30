using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class AlliesWaitingZone : MonoBehaviour
{
    private MetaGameManager manager;

    public SpriteAtlas alliesAtlas;

    public GameObject herald;
    public GameObject knight;
    public GameObject assassin;
    public GameObject wizard;
    void Start()
    {
        manager = MetaGameManager._instance;
        herald.GetComponent<SpriteRenderer>().enabled = false;
        knight.GetComponent<SpriteRenderer>().enabled = false;
        assassin.GetComponent<SpriteRenderer>().enabled = false;
        wizard.GetComponent<SpriteRenderer>().enabled = false;
    }

    void Update(){
        List<Player> pList = manager.getActivePlayers().FindAll( p => p.position == null);
        renderPlayer(pList, alliesAtlas);
    }

    public void renderPlayer(List<Player> list, SpriteAtlas atlas){
        foreach(Player p in list){
            GameObject o = null;
            switch(p.type){
                case PlayersAvailable.WIZARD :
                    o = wizard;
                    break;
                case PlayersAvailable.HERALD :
                    o = herald;
                    break;
                case PlayersAvailable.ASSASSIN :
                    o = assassin;
                    break;
                case PlayersAvailable.KNIGHT :
                    o = knight; 
                    break;
            }
            
            o.GetComponent<SpriteRenderer>().sprite = atlas.GetSprite(p.textureName);
            o.GetComponent<SpriteRenderer>().enabled = true;
            
        }
    }
}
