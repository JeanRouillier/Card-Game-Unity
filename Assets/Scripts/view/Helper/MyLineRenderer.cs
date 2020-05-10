using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(LineRenderer))]
public class MyLineRenderer : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public GameObject from;
    public GameObject to;
    public GameObject middlePoint;
    
    private int nbPoints = 30;
    private Vector3[] positions = new Vector3[30];
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = nbPoints;
        lineRenderer.material = new Material(Shader.Find("Sprites/Default"));
        lineRenderer.sortingLayerName = "allAbove";
        lineRenderer.sortingOrder = 9;
    }

    // Update is called once per frame
    void Update()
    {
        if( from != null && to != null){
            lineRenderer.startWidth = 10f;
            lineRenderer.endWidth = 5f;
            
            for(int i = 1; i < nbPoints +1; i++){
                float t = i / (float) nbPoints;
                Vector3 p =  getQuadraticCurvePosition(from.transform.position, to.transform.position, middlePoint.transform.position, t);
                positions[i-1] = p;
            }
            lineRenderer.SetPositions(positions);
        }
    }


    private Vector3 getQuadraticCurvePosition(Vector3 from, Vector3 to, Vector3 middle, float t){
        // (1-r) from + 2(1-t)t to + t 2middle
            return (1-t)*(1-t)*from + 2*(1-t)*t*middle + t*t*to;
        }
}
