using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pexeso : MonoBehaviour {
    
    List<GameObject> list = new List<GameObject>();
    int cardsAmount;
    float cardX;
    float cardY;
    Material currentMat;
    Renderer rndr;
    int rn1; //random number
    int rn2; //random number
    Vector3 coord1; //coordinations
    Vector3 coord2;
	// Use this for initialization
	void Start () {
        cardsAmount = 16;
        int i = 0;
        while (i < cardsAmount)
        {
            list.Add(Resources.Load<GameObject>("pexeso/card"));
            Instantiate(list[i]);

            cardX = i % 4;
            cardY = int.Parse( (i / 4).ToString());
            list[i].transform.position = new Vector3(cardX, cardY, 0);

            switch (int.Parse(((i/2)+1).ToString()))
            {
                case 1:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat01", typeof(Material)) as Material;
                    break;
                case 2:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat02", typeof(Material)) as Material;
                    break;
                case 3:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat03", typeof(Material)) as Material;
                    break;
                case 4:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat04", typeof(Material)) as Material;
                    break;
                case 5:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat05", typeof(Material)) as Material;
                    break;
                case 6:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat06", typeof(Material)) as Material;
                    break;
                case 7:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat07", typeof(Material)) as Material;
                    break;
                case 8:
                    rndr = list[i].GetComponent<Renderer>();
                    rndr.material = Resources.Load("pexeso/mat08", typeof(Material)) as Material;
                    break;
            }

            i++;
        }
        i = 0;
        while (i < 50)
        {
            rn1 = Random.Range(0, cardsAmount - 1);
            rn2 = Random.Range(0, cardsAmount - 1);



            i++;
        }
        
        list[4].transform.position = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
