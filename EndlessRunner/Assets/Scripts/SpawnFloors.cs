using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFloors : MonoBehaviour {

    public List<GameObject> floors;
    public GameObject positionToSpawn;
    public float TimeInterval;
    float nextSpawnTime;
    bool isFloorCreated;
	// Use this for initialization
	void Start () {
        nextSpawnTime = Time.time + TimeInterval;
        isFloorCreated = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!isFloorCreated)
        {
            if (Time.time > nextSpawnTime)
            {
                int index = Random.Range(0, floors.Count);
                GameObject go = Instantiate(floors.ToArray()[index], new Vector3(positionToSpawn.transform.position.x, positionToSpawn.transform.position.y, positionToSpawn.transform.position.z), positionToSpawn.transform.rotation) as GameObject;
                isFloorCreated = true;
                nextSpawnTime += TimeInterval;
            }
        }
	}
}
