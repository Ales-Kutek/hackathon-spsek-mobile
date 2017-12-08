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
        int rn = -1;

        while (round < 8)
        {
            round += 1;

            rn = Random.Range(1, 8);
            
            switch (rn)
            {
                case 1:
                    ShuffleMe(img1);
                    break;
                case 2:
                    ShuffleMe(img2);
                    break;
                case 3:
                    ShuffleMe(img3);
                    break;
                case 4:
                    ShuffleMe(img4);
                    break;
                case 5:
                    ShuffleMe(img5);
                    break;
                case 6:
                    ShuffleMe(img6);
                    break;
                case 7:
                    ShuffleMe(img7);
                    break;
                case 8:
                    ShuffleMe(img8);
                    break;
            }

            

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void ShuffleMe (GameObject go)
    {
        Transform myTransform = go.GetComponent<Transform>();
        Transform blankTransform = GameObject.Find("imgBlank").GetComponent<Transform>();

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
