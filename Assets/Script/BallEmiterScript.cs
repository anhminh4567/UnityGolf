using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallEmiterScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject BallToBeCreated;
    private float BaseSpawnTime;
    public float BallSpawnTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn()) 
        {
            SpawnBall();
        }
    }
    private bool ShouldSpawn() 
    {
        return Time.time >= BaseSpawnTime;
    }
    private void SpawnBall() 
    {
        Vector3 vectorRandomSpawn = new Vector3 (Random.Range(-0.2f,0.2f),0,0);
        BaseSpawnTime = Time.time + BallSpawnTime;
        Instantiate(BallToBeCreated,transform.position + vectorRandomSpawn,transform.rotation);//clone
    }
}
