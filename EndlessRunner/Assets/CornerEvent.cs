using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CornerEvent : MonoBehaviour {

    //public UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl m_character;
    // Use this for initialization
    void Start () {
		
	}
	void OnTriggerEnter(Collider other)
    {
       var m_character = other.GetComponent<UnityStandardAssets.Characters.ThirdPerson.ThirdPersonUserControl>();
        m_character.SetCanTurn(true);
    }
	// Update is called once per frame
	void Update () {
		
	}
}
