using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragNScript : MonoBehaviour
{
    public float power = 10f;
    public Rigidbody2D rigidBody; // to apply force to the ball
    public Vector2 minPower;
    public Vector2 maxPower;

    public LineTrajectory lineTrajectory;

    Camera cam;

    Vector2 forceApply;
    Vector3 startPoint;
    Vector3 endPoint;
    public DragNScript()
    {
    }

    // Start is called before the first frame update
    void Start ()
    {
        this.cam = Camera.main;
        lineTrajectory = GetComponent<LineTrajectory>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            startPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            startPoint.z = 15;
            //Debug.Log(startPoint);
        }
        if (Input.GetMouseButton(0)) 
        {
            endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            endPoint.z = 15;
            forceApply = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));

            Vector3 currentPos = cam.ScreenToWorldPoint(Input.mousePosition);
            currentPos.z = 15;
            lineTrajectory.RenderLine(rigidBody.position,endPoint);
            //rigidBody.AddForce(forceApply * power, ForceMode2D.Impulse);
        }
        if(Input.GetMouseButtonUp(0))
        {
            //endPoint = cam.ScreenToWorldPoint(Input.mousePosition);
            //endPoint.z = 15;
            //forceApply = new Vector2(Mathf.Clamp(startPoint.x - endPoint.x, minPower.x, maxPower.x), Mathf.Clamp(startPoint.y - endPoint.y, minPower.y, maxPower.y));
            rigidBody.AddForce(forceApply * power, ForceMode2D.Impulse);
            lineTrajectory.EndLine();
        }

    }
}
