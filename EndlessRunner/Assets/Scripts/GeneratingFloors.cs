using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratingFloors : MonoBehaviour {
    public List<GameObject> floorsStraight;
    public List<GameObject> floorsCorners;
    Transform t;
	// Use this for initialization
    void Awake()
    {
         t = new GameObject().transform; 
    }
	void Start () {
       
        var location = new Vector3(t.transform.position.x, t.transform.position.y, t.transform.position.z);
        var rot = t.rotation;
        
		for(int counter=0; counter < 6; ++counter)
        {
            int r = Random.Range(0, floorsStraight.Count);
            GameObject go = Instantiate(floorsStraight.ToArray()[r], location, rot) as GameObject;
            
            location = new Vector3(go.transform.Find("SpawnPoint").transform.position.x, go.transform.Find("SpawnPoint").transform.position.y, go.transform.Find("SpawnPoint").transform.position.z);
            rot = go.transform.Find("SpawnPoint").transform.rotation;  
        }
        int r2 = Random.Range(0, floorsStraight.Count);
        GameObject go2 = Instantiate(floorsStraight.ToArray()[r2], location, rot) as GameObject;
        go2.GetComponent<SpawnFloors>().StartCoroutine("Create");
    }
    public void GenerateFloor(GameObject spawnpoint)
    {
        int r = Random.Range(0, floorsCorners.Count);
        GameObject go = Instantiate(floorsCorners.ToArray()[r], new Vector3(spawnpoint.transform.position.x, spawnpoint.transform.position.y, spawnpoint.transform.position.z ), spawnpoint.transform.rotation) as GameObject;
        go.GetComponent<SpawnFloors>().StartCoroutine("Create");
    }
	// Update is called once per frame
	void Update () {
		
	}
}
