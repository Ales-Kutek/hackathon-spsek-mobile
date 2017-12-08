using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pexeso : MonoBehaviour {

    List<GameObject> list = new List<GameObject>();
    int cardsAmount;
	// Use this for initialization
	void Start () {
        cardsAmount = 16;
        int i = 0;
        while (i < cardsAmount)
        {
            list.Add(Resources.Load<GameObject>("pexeso/card"));
            Instantiate(list[i]);
            list[i].transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);

            i++;
        }
        
        list[4].transform.position = new Vector3(3, 3, 3);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
