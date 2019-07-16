using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletSpawnScript : MonoBehaviour {

	private float time = 0.0f;
	public float timePeriod = 1.0f;
	public int bullets = 10;
    public GameObject bullet;

    public AudioSource BulletFireSound;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(bullets == 0)
		{
			Destroy(transform.parent.gameObject);
			//Destroy(this);
		}

		time += Time.deltaTime;

		if (time >= timePeriod)
		{
			time = time - timePeriod;
            Vector3 vec = new Vector3(transform.position.x, transform.position.y, transform.position.z);         
            Instantiate(bullet, vec, Quaternion.identity);
            BulletFireSound.Play();
            bullets--;
		}
	}
}
