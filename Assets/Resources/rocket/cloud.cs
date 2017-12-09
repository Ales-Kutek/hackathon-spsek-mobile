using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour {
    
    Transform tr;
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
        tr.position = new Vector3(Random.Range(-20,20),40,5);
	}
	
	// Update is called once per frame
	void Update () {
        if (tr.position.y > -40)
        {
            tr.position = new Vector3(tr.position.x, tr.position.y - 0.5f, 5);
        }
        else
        {
            Destroy(this.gameObject);
        }
	}
}
