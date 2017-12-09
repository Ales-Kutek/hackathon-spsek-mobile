using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class login_script : MonoBehaviour
{
	public InputField LoginInput;
	
	// Use this for initialization
	void Start ()
	{
		user.username = LoginInput.text;
	}

	private void OnMouseOver()
	{
		SceneManager.LoadScene("Resources/core/MainMenu");
	}

	// Update is called once per frame
	void Update () {
		
	}
}
