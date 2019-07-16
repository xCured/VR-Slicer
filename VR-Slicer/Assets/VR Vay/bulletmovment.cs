using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovment : MonoBehaviour {

    // The target marker.
    public GameObject player;
    // Speed in units per sec.
    public float speed;
    public Vector3 playertransform;
    // Use this for initialization
    public Vector3 bulletPos;
    public float thrust;
    public Rigidbody rb;
    public float Ydisappear;
    private bool insideForce = false;

    public float torque;


    public AudioSource missileWhistle;

    public AudioSource explostionSound;

    private bool test=false;
    void Start()
    {
        player = GameObject.FindWithTag("follower");
        playertransform = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
       // bulletPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        rb = GetComponent<Rigidbody>();
        thrust = 1.0f;
        transform.LookAt(playertransform);

        missileWhistle.Play();
    

    }

    // Update is called once per frame
    void Update()
    {
       
        if (test == false)
        {
            player = GameObject.FindWithTag("follower");
            playertransform = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            transform.LookAt(playertransform);
            test = true;
        }
        rb.AddForce(transform.forward * thrust);

        if(insideForce == true)
        {
            rb.velocity = rb.velocity.normalized * 0.2f;
        }
        float turn = Input.GetAxis("Horizontal");
       // rb.AddTorque(0,0,10);

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("follower"))
        {
            missileWhistle.Stop();
            AudioSource.PlayClipAtPoint(explostionSound.clip, transform.position);
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Destroyer")
        {
            missileWhistle.Stop();
            AudioSource.PlayClipAtPoint(explostionSound.clip,transform.position);
            Destroy(gameObject);
        }


    }

    void OnTriggerEnter(Collider collision)
    {
       
        if (collision.gameObject.CompareTag("force"))
        {
            insideForce = true;
        }
        
    }

    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("force"))
        {
            insideForce = false;
        }
    }
}
