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
        List<Enemy> placed = manager.GetEnemiesBoard().getAllPlaced() ;
        if(placed.Count > 0){
            List<Enemy> row0 = placed.FindAll( e => e.position.x == 0).ToList();
            List<Enemy> row1 = placed.FindAll( e => e.position.x == 1).ToList();
            
            frontLane.renderContent(row0, enemiesAtlas);
            backLane.renderContent(row1, enemiesAtlas);
            
        }        
    }

    public GameObject getEnemyGameObject(Enemy e){
        GameObject result = null;
        if(e.position != null){
            if(e.position.y == 0){
                result = frontLane.getEnemyGameObjectByposition(e.position);
            }else if(e.position.y == 1){
                result = backLane.getEnemyGameObjectByposition(e.position);
            }
        }
        return result;
    }
}
