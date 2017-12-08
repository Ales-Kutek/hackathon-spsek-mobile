using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuffle : MonoBehaviour {

    GameObject img1;
    GameObject img2;
    GameObject img3;
    GameObject img4;
    GameObject img5;
    GameObject img6;
    GameObject img7;
    GameObject img8;
    GameObject imgBlank;

    // Use this for initialization
    void Start () {
        img1 = GameObject.Find("img1");
        img2 = GameObject.Find("img2");
        img3 = GameObject.Find("img3");
        img4 = GameObject.Find("img4");
        img5 = GameObject.Find("img5");
        img6 = GameObject.Find("img6");
        img7 = GameObject.Find("img7");
        img8 = GameObject.Find("img8");
        imgBlank = GameObject.Find("imgBlank");

        int round = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
