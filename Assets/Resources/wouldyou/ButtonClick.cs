using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{

	private Button trueButton;
	private Button falseButton;
	
	// Use this for initialization
	void Start ()
	{
		trueButton = GameObject.FindGameObjectWithTag("trueButton").GetComponent<Button>();
		falseButton = GameObject.FindGameObjectWithTag("falseButton").GetComponent<Button>();
		
		trueButton.onClick.AddListener(TrueClicked);
		falseButton.onClick.AddListener(FalseClicked);
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void TrueClicked()
	{
		GameObject.FindGameObjectWithTag("trueText").GetComponent<Text>().text = "55%";
		GameObject.FindGameObjectWithTag("falseText").GetComponent<Text>().text = "45%";
		
		Thread.Sleep(2000);
		
		//Application.Quit();
	}

	void FalseClicked()
	{
		TrueClicked();
	}
}
