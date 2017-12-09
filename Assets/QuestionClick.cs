using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionClick : MonoBehaviour
{

	private GameObject _button;
	// Use this for initialization
	void Start () {
		GameObject.FindGameObjectWithTag("questionButton").GetComponent<Button>().onClick.AddListener(DoIt);
	}
	
	void DoIt()
	{
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
