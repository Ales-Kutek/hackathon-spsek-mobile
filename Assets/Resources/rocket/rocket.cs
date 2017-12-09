using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {

    GameObject arrowU;
    GameObject arrowD;
    GameObject arrowL;
    GameObject arrowR;

    float topYConstraint = 5;
    float botYConstraint = -5;
    float leftXConstraint =-5;
    float rightXConstraint =5;

    int ticksTillCloud = 10;

    Rigidbody2D rb;
    Transform tr;

    Camera c;

    // Use this for initialization
    void Start () {
        arrowU = GameObject.Find("arrowU");
        arrowD = GameObject.Find("arrowD");
        arrowL = GameObject.Find("arrowL");
        arrowR = GameObject.Find("arrowR");
        c = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (btnPressed(arrowU))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y+0.3f, 0);
        }
        if (btnPressed(arrowD))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y -0.15f, 0);
        }
        if (btnPressed(arrowL))
        {
            rb.velocity = new Vector3(rb.velocity.x - 0.3f, rb.velocity.y, 0);
        }
        if (btnPressed(arrowR))
        {
            rb.velocity = new Vector3(rb.velocity.x + 0.3f, rb.velocity.y, 0);
        }


        if (ticksTillCloud > 0)
        {
            ticksTillCloud--;
        }
        else
        {
            ticksTillCloud = Random.Range(10, 50);
            Instantiate(Resources.Load("rocket/goCloud"));
        }


        if (tr.position.x > rightXConstraint)
        {
            transform.position = new Vector3(rightXConstraint, transform.position.y, 0);
        }
        if (tr.position.x < leftXConstraint)
        {
            transform.position = new Vector3(leftXConstraint, transform.position.y, 0);
        }

        /*
        if (tr.position.y > topYConstraint)
        {
            transform.position = new Vector3(transform.position.x, topYConstraint, 0);
        }
        if (tr.position.y < botYConstraint)
        {
            transform.position = new Vector3(transform.position.x, botYConstraint, 0);
        }
        */

    }

    bool btnPressed(GameObject btn)
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mouseCoordinates = c.ScreenToWorldPoint(Input.mousePosition);

            if (mouseCoordinates.x < (btn.transform.position.x + btn.transform.lossyScale.x)
                    && mouseCoordinates.x > (btn.transform.position.x - btn.transform.lossyScale.x)
                    && mouseCoordinates.y < (btn.transform.position.y + btn.transform.lossyScale.y)
                    && mouseCoordinates.y > (btn.transform.position.y - btn.transform.lossyScale.y)
               )
            {
                return true;
            }
        }

        return false;
    }
}
