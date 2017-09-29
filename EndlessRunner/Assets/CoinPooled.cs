using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPooled : MonoBehaviour {
    
   public GameObject forward;
   public GameObject left;
   public GameObject right;

	// Use this for initialization
	void Start () {
        forward.SetActive(false);
        right.SetActive(false);
        left.SetActive(false);
        float prob = Random.Range(0f,1f);
        if(prob<0.5)
            forward.SetActive(true);
         prob = Random.Range(0f, 1f); 
        if (prob < 0.5)
            right.SetActive(true);
         prob = Random.Range(0f, 1f); 
        if (prob < 0.5)
            left.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
