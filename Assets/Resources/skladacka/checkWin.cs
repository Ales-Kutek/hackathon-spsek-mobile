using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checkWin : MonoBehaviour {

    Transform img1;
    Transform img2;
    Transform img3;
    Transform img4;
    Transform img5;
    Transform img6;
    Transform img7;
    Transform img8;
    Transform imgBlank;

    // Use this for initialization
    void Start () {
        img1 = GameObject.Find("img1").GetComponent<Transform>();
        img2 = GameObject.Find("img2").GetComponent<Transform>();
        img3 = GameObject.Find("img3").GetComponent<Transform>();
        img4 = GameObject.Find("img4").GetComponent<Transform>();
        img5 = GameObject.Find("img5").GetComponent<Transform>();
        img6 = GameObject.Find("img6").GetComponent<Transform>();
        img7 = GameObject.Find("img7").GetComponent<Transform>();
        img8 = GameObject.Find("img8").GetComponent<Transform>();
        imgBlank = GameObject.Find("imgBlank").GetComponent<Transform>();

    }
	
	// Update is called once per frame
	void Update () {

        if (
               img1.position.x == -2.1f && img1.position.y == 2.1f
            && img2.position.x == 0f && img2.position.y == 2.1f
            && img3.position.x == 2.1f && img3.position.y == 2.1f
            && img4.position.x == -2.1f && img4.position.y == 0f
            && img5.position.x == 0f && img5.position.y == 0f
            && img6.position.x == 2.1f && img6.position.y == 0f
            && img7.position.x == -2.1f && img7.position.y == -2.1f
            && img8.position.x == 0f && img8.position.y == -2.1f


            )
        {
            SceneManager.LoadScene("Resources/skladacka/puzzle_shuffle_win_scene");
        }

	}
}
