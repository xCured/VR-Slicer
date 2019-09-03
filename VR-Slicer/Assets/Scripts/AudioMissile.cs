using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XftWeapon;
using EzySlice;
using UnityEditor;
using UnityEngine.SceneManagement;

public class AudioMissile : MonoBehaviour {
    public AudioClip musicClip;

    int MaxRefelctionCount = 5;
    float MaxStep = 200;

    public AudioSource musicSource;

    // Use this for initialization
    void Start () {
       // musicClip = GetComponent<AudioSource>().clip;
        //musicSource = GetComponent<AudioSource>();
        //musicSource.Play();
	}
	
	// Update is called once per frame
	public void Update () {
        
    }


   
        //private void OnDrawGizmos()
        //{
        //    Handles.color = Color.red;
        //    Handles.ArrowHandleCap(0, this.transform.position + this.transform.forward * 0.25f, this.transform.rotation, 0.5f, EventType.Repaint);

        //    Gizmos.color = Color.red;
        //    Gizmos.DrawWireSphere(this.transform.position, 0.25f);

        //    DrawPredictions(this.transform.position + this.transform.forward * 0.75f, this.transform.forward, MaxRefelctionCount);
        //}
        //public void DrawPredictions(Vector3 Position, Vector3 Direction, int ReflectionsRemain)
        //{
        //    if (ReflectionsRemain == 0)
        //    {
        //        return;
        //    }
        //    Vector3 StartingPosition = Position;

        //    Ray ray = new Ray(Position, Direction);
        //    RaycastHit hit;

        //    if (Physics.Raycast(ray, out hit, MaxStep))
        //    {

        //        Vector3 RelectDir = Vector3.Reflect(ray.direction, hit.normal);

        //        float rot = Mathf.Atan2(RelectDir.z, RelectDir.x) * Mathf.Rad2Deg;
        //        transform.eulerAngles = new Vector3(0, rot, 0);


        //        Direction = Vector3.Reflect(Direction, hit.normal);
        //        Position = hit.point;

        //    }
        //    else
        //    {
        //        Position += Direction * MaxStep;
        //    }
        //    Gizmos.color = Color.yellow;
        //    Gizmos.DrawLine(StartingPosition, Position);
        //    DrawPredictions(Position, Direction, ReflectionsRemain - 1);
        //}
    }
