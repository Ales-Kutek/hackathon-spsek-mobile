using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getName : MonoBehaviour
{

	public Text NameText;

	public Text PointsText;
	
	// Use this for initialization
	void Start ()
	{
		NameText.text = user.username;
		PointsText.text = user.points.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
