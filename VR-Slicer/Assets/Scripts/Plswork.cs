using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XftWeapon;
using EzySlice;
using UnityEngine.SceneManagement;

public class Plswork : MonoBehaviour {
    public GameObject objectToSlice;
    public GameObject Upper_Hull;
    public float timeDestroyal;
    public float TimeStamp = 1.0f;
    List<GameObject> golist = new List<GameObject>();
    public GameObject Activate;

    public AudioClip musicClip;

    public AudioSource musicSource;

    public GameObject[] Slice(Vector3 planeWorldPosition, Vector3 planeWorldDirection, TextureRegion region)
    {
        
        return objectToSlice.SliceInstantiate(this.transform.position, this.transform.forward, region);
        
    }
    private void Start()
    {
        Activate.gameObject.SetActive(true);
        musicSource = GetComponent<AudioSource>();
    }
    void Update()
    {
      
    }



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
