using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class HandUI : MonoBehaviour
{
    private MetaGameManager manager;

    public SpriteAtlas starterAtlas;
    public SpriteAtlas upgradeAtlas;
    
    public List<GameObject> cards;
    public PlayersAvailable type;

    void Start()
    {
        manager = MetaGameManager._instance;
    }

    // Update is called once per frame
    void Update()
    {
        List<Card> cardList = manager.getActivePlayers().Find( p => p.type == type).hand;
        for(int i = 0; i<= cardList.Count; i++){
            Sprite result = null;
            if(cardList[i].isStarter){
                result = starterAtlas.GetSprite(cardList[i].textureName);
            }else{
                result = upgradeAtlas.GetSprite(cardList[i].textureName);
            }
            cards[i].GetComponent<SpriteRenderer>().sprite = result;
        }
    }
}
