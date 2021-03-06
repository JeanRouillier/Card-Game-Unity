﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private float dist;
    private Vector3 MouseStart;
    private Vector3 derp;

    private float targetZoom;
    private float zoomFactor = 200f;
    private float zoomLerpSpeed = 10;

    public new Camera camera;
    
    void Start(){
         dist = transform.position.z;  // Distance camera is above map   
         targetZoom = camera.orthographicSize;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) {
        MouseStart = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
        MouseStart = camera.ScreenToWorldPoint (MouseStart);
        MouseStart.z = transform.position.z;

        } 
        else if (Input.GetMouseButton(1)) {
            var MouseMove = new Vector3(Input.mousePosition.x, Input.mousePosition.y, dist);
            MouseMove = camera.ScreenToWorldPoint (MouseMove);
            MouseMove.z = transform.position.z;
            transform.position = transform.position - (MouseMove - MouseStart);
        }

        float scrollData;
        scrollData = Input.GetAxis("Mouse ScrollWheel");
        targetZoom -= scrollData * zoomFactor;
        targetZoom = Mathf.Clamp(targetZoom,  20, 300);
        camera.orthographicSize = Mathf.Lerp(camera.orthographicSize , targetZoom, Time.deltaTime * zoomLerpSpeed);
    } 
}
