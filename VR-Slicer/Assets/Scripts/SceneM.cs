﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneM : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision coll)
    {
     
    }

    IEnumerator LoadWithDelay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);

    }
}
