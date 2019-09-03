using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretController : MonoBehaviour
{
	private Transform playerHead;


	// Use this for initialization
	void Start()
	{
		playerHead = GameObject.FindWithTag("follower").transform; //find head transform
	}

	// Update is called once per frame
	void Update()
	{
		transform.LookAt (playerHead);  //point towards player head transform
	}
}
