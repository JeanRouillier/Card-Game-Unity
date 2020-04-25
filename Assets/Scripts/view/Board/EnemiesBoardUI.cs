using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.U2D;

public class EnemiesBoardUI : MonoBehaviour
{
    private MetaGameManager manager;
    
    public SpriteAtlas enemiesAtlas;

    public Lane frontLane;
    public Lane backLane;

    // Start is called before the first frame update
    void Start()
    {
        manager = MetaGameManager._instance;
    }

    // Update is called once per frame
    void Update()
    {
        List<Person> placed = manager.GetEnemiesBoard().getAllPlacedEnemies() ;
        if(placed.Count > 0){
            List<Person> row0 = placed.FindAll( e => e.position.x == 0).ToList();
            List<Person> row1 = placed.FindAll( e => e.position.x == 1).ToList();
            
            frontLane.renderContent(row0, enemiesAtlas);
            backLane.renderContent(row1, enemiesAtlas);
        }

        
    }
}
