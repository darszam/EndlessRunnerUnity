using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            var otherCoin = other.GetComponent<CollectingCoins>();
            otherCoin.AddCoin();
            Destroy(gameObject);
        }
    }
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 5, 0, Space.World);
    }
}
