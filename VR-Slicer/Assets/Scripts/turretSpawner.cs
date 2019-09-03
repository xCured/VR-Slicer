using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretSpawner : MonoBehaviour {

	private float time = 0.0f;
	public float timePeriod = 3.0f;
	public GameObject turret;

	private float minDist = 15.0f;
	private float maxDist = 25.0f;


    public AudioSource spawnerSound;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update()
	{

		time += Time.deltaTime;

		if (time >= timePeriod)
		{
			time = time - timePeriod;
			Vector3 vec = new Vector3();
			while (vec == null || vec.x < minDist && vec.z < minDist)
			{
				vec = new Vector3(Random.Range(-maxDist, maxDist), Random.Range(5.0f, 10.0f), Random.Range(-maxDist, maxDist));
			}
			Instantiate(turret, vec, Quaternion.identity);
            spawnerSound.Play();
		}
	}
}
