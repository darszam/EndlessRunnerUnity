using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFloor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 2);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
