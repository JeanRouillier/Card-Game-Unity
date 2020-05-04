using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class MyLineRenderer : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public GameObject from;
    public GameObject to;
    

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if( from != null && to != null){
            lineRenderer.startWidth = 15f;
            lineRenderer.endWidth = 15f;
            
            lineRenderer.positionCount = 2;
            lineRenderer.SetPosition(0, from.transform.position);
            lineRenderer.SetPosition(1, to.transform.position);
        }
    }
}
