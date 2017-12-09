using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
	}

	void DoIt()
	{
		user.username = LoginInput.text;
		SceneManager.LoadScene("Resources/core/MainMenu");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
