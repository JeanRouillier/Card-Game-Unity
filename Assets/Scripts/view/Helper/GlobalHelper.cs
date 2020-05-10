using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalHelper 
{
    public static void drawArrow(GameObject from, GameObject to){
        MyLineRenderer lr = new GameObject().AddComponent<MyLineRenderer>();
        GameObject middlePoint = new GameObject();
        middlePoint.transform.position = Vector3.Lerp(from.transform.position, to.transform.position, 0.5f);
        middlePoint.transform.position = new Vector3(middlePoint.transform.position.x, 
                                                    middlePoint.transform.position.y +50,
                                                    0);
        lr.from = from;
        lr.to = to;
        lr.middlePoint = middlePoint;
    }
}
