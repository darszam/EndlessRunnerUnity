using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningObstacles : MonoBehaviour {

    public
        GameObject firstPos;
    public GameObject secondPos;
    public GameObject thirdPos;
    public GameObject obstacle;
    GameObject left;
    GameObject center;
    GameObject right;
	// Use this for initialization
    void Awake()
    {/*
        center = GameObject.Find("ForwardSpawnPoint/Capsule(Clone)");
        left = GameObject.Find("LeftSpawnPoint/Capsule(Clone)");
        right = GameObject.Find("RightSpawnPoint/Capsule(Clone)");
        if (center != null)
            Destroy(center);
        if (left != null)
            Destroy(left);
        if (right != null)
            Destroy(right);*/
        GameObject[] t = new GameObject[] { firstPos, secondPos, thirdPos };
        List<GameObject> array = new List<GameObject>();
        array.AddRange(t);

        GameObject firstchosen = array[Random.Range(0, array.Count)];
        GameObject go = Instantiate(obstacle, new Vector3(firstchosen.transform.position.x, firstchosen.transform.position.y, firstchosen.transform.position.z), new Quaternion(0, 0, 0, 0)) as GameObject;
        go.transform.SetParent(firstchosen.transform);
        //go.transform.position = new Vector3(0, 0, 0);
        array.Remove(firstchosen);
        GameObject secondchosen = array[Random.Range(0, array.Count)];


        GameObject go2 = Instantiate(obstacle, new Vector3(secondchosen.transform.position.x, secondchosen.transform.position.y, secondchosen.transform.position.z), new Quaternion(0, 0, 0, 0)) as GameObject;
        go2.transform.SetParent(secondchosen.transform);
        //go2.transform.position = new Vector3(0, 0, 0);
    }
    void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
