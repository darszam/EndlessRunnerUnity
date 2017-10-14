using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloors : MonoBehaviour {

    public List<GameObject> floors;
    public GameObject positionToSpawn;
    public float TimeInterval;
    GameObject gm;
    
    float nextSpawnTime;
    bool isFloorCreated;
	// Use this for initialization
	void Start () {
        nextSpawnTime = Time.time + TimeInterval;
        isFloorCreated = false;
        gm = GameObject.FindGameObjectWithTag("GameManager");
	}
	public void SetIsFloorCreated(bool b)
    {
        isFloorCreated = b;
    }
    public IEnumerator Create()
    {
        yield return new  WaitForSeconds(3);
        gm.GetComponent<GeneratingFloors>().GenerateFloor(positionToSpawn);
    }
	// Update is called once per frame
	void Update () {
        
                
                
         
	}
}
