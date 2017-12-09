using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftConstraint : MonoBehaviour {

    /*
     * ALSO CHANGES RIGHT CONSTRAINT
     */

    Transform trL;
    Transform trR;

    Camera c;

	void Start () {
        trL = GetComponent<Transform>();
        trR = GameObject.Find("rightConstraint").GetComponent<Transform>();
        c = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 leftEnd = c.ScreenToWorldPoint(new Vector3(0, 0, 0));
        trL.position = new Vector3(leftEnd.x - 1, trL.position.y, 0);
        Vector3 rightEnd = c.ScreenToWorldPoint(new Vector3(c.pixelWidth, 0, 0));
        trR.position = new Vector3(rightEnd.x + 1, trR.position.y, 0);
	}
}
