using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingCoins : MonoBehaviour {
    public Text coinsAmount;
    int intCoinsAmount;
	// Use this for initialization
	void Start () {
        intCoinsAmount = 0;
        coinsAmount.text = "0";
	}
	public void AddCoin()
    {
        intCoinsAmount++;
        coinsAmount.text = intCoinsAmount.ToString();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
