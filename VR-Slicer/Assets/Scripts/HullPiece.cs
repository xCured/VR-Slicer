using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HullPiece : MonoBehaviour {

    public float Timeout = 1;

    private void Start()
    {
        GameManager.Instance.hullManager.HullPieces.Add(this.gameObject);
        this.gameObject.AddComponent<Rigidbody>();
        this.gameObject.AddComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update () {
		if ((Timeout -= Time.deltaTime) <= 0f)
        {
            GameManager.Instance.hullManager.HullPieces.Remove(gameObject);
            Destroy(this.gameObject);
        }


	}
}
