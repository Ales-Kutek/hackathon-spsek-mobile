using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swap : MonoBehaviour {
    
	
	Camera c;
	GameObject goBlank;
	Transform blankTransform;
	Transform myTransform;
	
	// Use this for initialization
	void Start () {

		c = Camera.main;
		goBlank = GameObject.Find("imgBlank");
		blankTransform = goBlank.GetComponent<Transform>();
		myTransform = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {

		blankTransform = goBlank.GetComponent<Transform>();
		myTransform = GetComponent<Transform>();

		if (Input.GetMouseButtonDown(0)){
			
			Vector3 mouseCoordinates = c.ScreenToWorldPoint(Input.mousePosition);

			if(     mouseCoordinates.x < (myTransform.position.x + myTransform.lossyScale.x / 2)
                    && mouseCoordinates.x > (myTransform.position.x - myTransform.lossyScale.x / 2)
                    && mouseCoordinates.y < (myTransform.position.y + myTransform.lossyScale.y / 2)
                    && mouseCoordinates.y > (myTransform.position.y - myTransform.lossyScale.y / 2)

                  )
                {
	                if (
						   myTransform.position.x == blankTransform.position.x && myTransform.position.y < blankTransform.position.y + 2.2f
		                || myTransform.position.x == blankTransform.position.x && myTransform.position.y < blankTransform.position.y - 2.2f
                        || myTransform.position.y == blankTransform.position.y && myTransform.position.x < blankTransform.position.x + 2.2f
                        || myTransform.position.y == blankTransform.position.y && myTransform.position.x < blankTransform.position.x - 2.2f
	             )
	             {

                    Vector3 myCoordinates = myTransform.position;
                    Vector3 blankCoordinates = blankTransform.position;

                    blankTransform.position = myCoordinates;
                    myTransform.position = blankCoordinates;

                }

					


                }



			



		}

		if (Input.GetKeyDown(KeyCode.B))
		{
			

		}





	}
}
