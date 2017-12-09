using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class login_script : MonoBehaviour
{
	public InputField LoginInput;

	public Button Button;

	// Use this for initialization
	void Start ()
	{
		LoginInput = GameObject.FindGameObjectWithTag("loginField").GetComponent<InputField>();

		GameObject.FindGameObjectWithTag("loginButton").GetComponent<Button>().onClick.AddListener(DoIt);
	}

	void DoIt()
	{
		user.username = LoginInput.text;
		UnityWebRequest myWr = UnityWebRequest.Get("http://10.10.5.193:8080/request/?do=name&name=" + LoginInput.text + "&score=" + user.points);
		myWr.Send();

		SceneManager.LoadScene("Resources/core/MainMenu");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
