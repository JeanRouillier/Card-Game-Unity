﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
private float dist;
private Vector3 MouseStart;
private Vector3 derp;
    
    void Start(){
         dist = transform.position.z;  // Distance camera is above map   
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
        MouseStart = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        MouseStart = Camera.main.ScreenToWorldPoint (MouseStart);
        MouseStart.z = transform.position.z;

    } 
    else if (Input.GetMouseButton(1)) {
        var MouseMove = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        MouseMove = Camera.main.ScreenToWorldPoint (MouseMove);
        MouseMove.z = transform.position.z;
        transform.position = transform.position - (MouseMove - MouseStart);
    }
    } 
}
