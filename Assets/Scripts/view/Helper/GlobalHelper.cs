using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalHelper 
{
    public static void drawArrow(GameObject from, GameObject to){
        MyLineRenderer lr = new GameObject().AddComponent<MyLineRenderer>();
        lr.from = from;
        lr.to = to;
    }
}
