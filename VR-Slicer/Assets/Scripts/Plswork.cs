using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XftWeapon;
using EzySlice;
using UnityEditor;
using UnityEngine.SceneManagement;

public class Plswork : MonoBehaviour {
    public GameObject objectToSlice;
    public GameObject Upper_Hull;
    int MaxRefelctionCount = 5;
    float MaxStep = 200;

    List<GameObject> golist = new List<GameObject>();
    public GameObject Activate;

    public AudioClip musicClip;

    public AudioSource musicSource;

    //public GameObject[] Slice(Vector3 planeWorldPosition, Vector3 planeWorldDirection, TextureRegion region)
    //{

    //    return objectToSlice.SliceInstantiate(this.transform.position, this.transform.forward, region);

    //}

    public SlicedHull Slice(Vector3 planeWorldPosition, Vector3 planeWorldDirection)
    {
        return objectToSlice.Slice(this.transform.position, this.transform.forward);
      

    }
    private void Start()
    {
        Activate.gameObject.SetActive(true);
        musicSource = GetComponent<AudioSource>();
    }
    void Update()
    {
      
    }

    //private void OnDrawGizmos()
    //{
    //    Handles.color = Color.red;
    //    Handles.ArrowHandleCap(0, this.transform.position +  this.transform.forward * 0.25f, this.transform.rotation, 0.5f, EventType.Repaint);

    //    Gizmos.color = Color.red;
    //    Gizmos.DrawWireSphere(this.transform.position, 0.25f);

    //    DrawPredictions(this.transform.position + this.transform.forward *0.75f, this.transform.forward, MaxRefelctionCount);
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

    //    if(Physics.Raycast(ray, out hit, MaxStep))
    //    {
    //        Direction = Vector3.Reflect(Direction, hit.normal);
    //        Position = hit.point;

    //    }
    //    else
    //    {
    //        Position += Direction * MaxStep;
    //    }
    //    Gizmos.color = Color.yellow;
    //    Gizmos.DrawLine(StartingPosition, Position );
    //    DrawPredictions(Position, Direction, ReflectionsRemain - 1);
    //}
   
    void OnCollisionEnter(Collision coll)
    {
        

        if (coll.gameObject.tag == "Box")
        {
            musicSource.Play();
            objectToSlice = coll.gameObject;
            objectToSlice.SliceInstantiate(this.transform.position, this.transform.forward);
            Destroy(objectToSlice);
        }

        if (coll.gameObject.tag == "GameStarter")
        {
            musicSource.Play();
            objectToSlice = coll.gameObject;
            objectToSlice.SliceInstantiate(this.transform.position, this.transform.forward);
            Destroy(objectToSlice);
            StartCoroutine(LoadWithDelay());

        }

    }

    IEnumerator LoadWithDelay()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);

    }


}
