using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour {
    public GameObject Activate;

    // Use this for initialization
    void Start () {
        Activate.gameObject.SetActive(true);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
