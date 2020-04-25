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
    // Start is called before the first frame update
    void Start()
    {
                manager = MetaGameManager._instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void renderContent(List<Person> placed, SpriteAtlas atlas){
        foreach(Person p in placed){
            int y = p.position.y;
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
            if(o != null){
                o.GetComponent<SpriteRenderer>().sprite = atlas.GetSprite(p.textureName);
            }
        }
    }
}
