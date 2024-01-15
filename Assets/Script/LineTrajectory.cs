using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineTrajectory : MonoBehaviour
{
    public LineRenderer lineRenderer;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    public void RenderLine(Vector3 startPoint, Vector3 endPoint) 
    {
        startPoint.z = 0;
        endPoint.z = 0;
        lineRenderer.positionCount = 2;
        Vector3[] points = new Vector3[2]; // set the position
        points[0] = startPoint;
        points[1] = endPoint;
        lineRenderer.SetPositions(points);
    }
    public void EndLine() 
    {
        lineRenderer.positionCount = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
