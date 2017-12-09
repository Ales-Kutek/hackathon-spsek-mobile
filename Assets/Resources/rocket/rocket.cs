using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour {
    
    GameObject turnL;
    GameObject turnR;

    Renderer healthBarRenderer;
    Transform healthBarTransform;

    float topYConstraint = 5;
    float botYConstraint = -5;
    float leftXConstraint =-5;
    float rightXConstraint =5;

    int ticksTillCloud = 10;
    int ticksTillSatellite = 50;
    int health = 4;

    Rigidbody2D rb;
    Transform tr;

    Transform trMore;



    Camera c;

    // Use this for initialization
    void Start () {
        turnL = GameObject.Find("turnL");
        turnR = GameObject.Find("turnR");
        c = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        healthBarRenderer = GameObject.Find("healthBar").GetComponent<Renderer>();
        healthBarRenderer.material = Resources.Load("rocket/matHp4", typeof(Material)) as Material;
        healthBarTransform = GameObject.Find("healthBar").GetComponent<Transform>();
        trMore = GameObject.Find("btnVice").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            Vector3 mouseCoordinates = c.ScreenToWorldPoint(Input.mousePosition);
            if (mouseCoordinates.x > 0 && mouseCoordinates.y > - 3.5)
            {
                rb.velocity = new Vector3(rb.velocity.x + 0.3f, rb.velocity.y, 0);
            }
            else if (mouseCoordinates.x < 0 && mouseCoordinates.y > -3.5)
            {
                rb.velocity = new Vector3(rb.velocity.x - 0.3f, rb.velocity.y, 0);
            }
            else if(mouseCoordinates.y < -3.5)
            {
                /*
                 * TLACITKO ZOBRAZIT VICE
                 */
            }
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


        if (ticksTillSatellite > 0)
        {
            ticksTillSatellite--;
        }
        else
        {
            ticksTillSatellite = Random.Range(40, 80);
            Instantiate(Resources.Load("rocket/goSatellite"));
        }

        tr.position = new Vector3(tr.position.x, -1, -1);

        Vector3 healthBarCoordinates = c.ScreenToWorldPoint( new Vector3(1,c.pixelHeight,-8));

        healthBarTransform.position = new Vector3(healthBarCoordinates.x+3, healthBarCoordinates.y-1.5f, -9);

        Vector3 moreBtnCoordinates = c.ScreenToWorldPoint(new Vector3(c.pixelWidth / 2, 10, -8));

        trMore.position = new Vector3(moreBtnCoordinates.x, moreBtnCoordinates.y, -8);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "satellite")
        {
            Destroy(collision.gameObject);
            switch (health)
            {
                case 4:
                    healthBarRenderer.material = Resources.Load("rocket/matHp3", typeof(Material)) as Material;
                    break;
                case 3:
                    healthBarRenderer.material = Resources.Load("rocket/matHp2", typeof(Material)) as Material;
                    break;
                case 2:
                    healthBarRenderer.material = Resources.Load("rocket/matHp1", typeof(Material)) as Material;
                    break;
                case 1:
                    healthBarRenderer.material = Resources.Load("rocket/matHp0", typeof(Material)) as Material;
                    break;
                case 0:
                    break;
            }
            health--;
        }
    }


}
