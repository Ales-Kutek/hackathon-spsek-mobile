using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using ZXing;
using ZXing.QrCode;
using System.Threading;
using UnityEngine.SceneManagement;

public class qr_reader : MonoBehaviour {


private WebCamTexture camTexture;
private Rect screenRect;
	private int i = 0;	

void Start() {
screenRect = new Rect(0, 0, 1920, 1080);
camTexture = new WebCamTexture();
camTexture.requestedHeight = 1920; 
camTexture.requestedWidth = 1080;
	if (camTexture != null)
	{
		camTexture.Play();
	}
}

void OnGUI ()
{
// drawing the camera on screen
// do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
	GUI.DrawTexture (screenRect, camTexture, ScaleMode.ScaleToFit);
	ScanQr();
	//i++;
	
	/*if (i > 300)
	{
		SceneManager.LoadScene("Resources/rocket/rocket_scene");
	}*/
}

	private void ScanQr()
	{
		try
		{
			IBarcodeReader barcodeReader = new BarcodeReader();
			// decode the current frame
			var result = barcodeReader.Decode(camTexture.GetPixels32(),
				camTexture.width, camTexture.height);
			if (result != null)
			{
				if (result.Text != "")
				{
					SceneManager.LoadScene("Resources/skladacka/puzzle_shuffle_scene");
				}
				
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(ex.Message);
		}
	}
}
