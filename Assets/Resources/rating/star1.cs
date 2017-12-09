using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star1 : MonoBehaviour {

    GameObject goStar1;
    GameObject star2;
    GameObject star3;
    GameObject star4;
    GameObject star5;
    Camera c;
    Renderer rndr1;
    Renderer rndr2;
    Renderer rndr3;
    Renderer rndr4;
    Renderer rndr5;

	// Use this for initialization
	void Start () {
        goStar1 = GameObject.Find("star1");
        star2 = GameObject.Find("star2");
        star3 = GameObject.Find("star3");
        star4 = GameObject.Find("star4");
        star5 = GameObject.Find("star5");
        c = Camera.main;
        rndr1 = goStar1.GetComponent<Renderer>();
        rndr2 = star2.GetComponent<Renderer>();
        rndr3 = star3.GetComponent<Renderer>();
        rndr4 = star4.GetComponent<Renderer>();
        rndr5 = star5.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update () {

        if (checkTouch(goStar1))
        {
        }
        if (checkTouch(star2))
        {

        }
        if (checkTouch(star3))
        {

        }
        if (checkTouch(star4))
        {

        }
        if (checkTouch(star5))
        {

        }


    }

    bool checkTouch(GameObject star)
    {
        Transform tr = star.GetComponent<Transform>();

        if (Input.GetMouseButtonDown(0))
        {

            Vector3 mouseCoordinates = c.ScreenToWorldPoint(Input.mousePosition);

            if (mouseCoordinates.x < (tr.position.x + tr.lossyScale.x)
                    && mouseCoordinates.x > (tr.position.x - tr.lossyScale.x)
                    && mouseCoordinates.y < (tr.position.y + tr.lossyScale.y)
                    && mouseCoordinates.y > (tr.position.y - tr.lossyScale.y)

                  )
            {
                return true;
            }
        }
        
        return false;
    }
}
