using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class go_qr_reader : MonoBehaviour
{
	private GameObject fingerPrint;
	private Camera c;
	
	// Use this for initialization
	void Start () {
		fingerPrint = GameObject.Find("Fingerprint");
		c = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0))
		{
			Vector3 mouseCoordinates = c.ScreenToWorldPoint(Input.mousePosition);

			if (mouseCoordinates.x < (fingerPrint.transform.position.x + 40)
			    && mouseCoordinates.x > (fingerPrint.transform.position.x - 40)
			    && mouseCoordinates.y < (fingerPrint.transform.position.y + 80)
			    && mouseCoordinates.y > (fingerPrint.transform.position.y - 80))
			{
				SceneManager.LoadScene("Resources/core/QrReader");
			}
		}
	}
}
