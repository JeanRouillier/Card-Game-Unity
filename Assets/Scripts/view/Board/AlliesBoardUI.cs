using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;


public class AlliesBoardUI : MonoBehaviour
{
    private MetaGameManager manager;
    
    public Lane frontLane;
    public Lane backLane;

    public AlliesWaitingZone waitingZone;
    // Start is called before the first frame update
    void Start()
    {
        manager = MetaGameManager._instance;
    }

    void Update()
    {

    }
}
