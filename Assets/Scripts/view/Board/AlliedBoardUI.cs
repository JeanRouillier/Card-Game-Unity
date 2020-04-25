using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;


public class AlliedBoardUI : MonoBehaviour
{
    private MetaGameManager manager;
    
    public SpriteAtlas alliesAtlas;

    public Lane frontLane;
    public Lane backLane;

    public AlliesWaitingZone waitingZone;
    // Start is called before the first frame update
    void Start()
    {
        manager = MetaGameManager._instance;
    }

    // Update is called once per frame
    void Update()
    {
        List<Person> placed = manager.GetAlliesBoard().getAllPlaced();
        if(placed.Count > 0){
            List<Person> row0 = placed.FindAll( e => e.position.x == 0);
            List<Person> row1 = placed.FindAll( e => e.position.x == 1);
            
            frontLane.renderContent(row0, alliesAtlas);
            backLane.renderContent(row1, alliesAtlas);
        }else{
            List<Player> list = manager.getActivePlayers();
            waitingZone.renderPlayer(list, alliesAtlas);
        }
    }
}
