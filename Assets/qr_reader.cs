using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using UnityEngine;
using ZXing;
using ZXing.QrCode;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class qr_reader : MonoBehaviour {

	private WebCamTexture camTexture;
	private Rect screenRect;
	private int i = 0;
	private bool run = true;

	private string _qrResult;

	public RawImage rawimage;

	private float _tapped = 0;

	void Start()
	{
		rawimage = GetComponent<RawImage>();
		camTexture = new WebCamTexture();

		transform.Rotate(Vector3.forward, 270);

		float W = Screen.width;
		float H = Screen.height;

		float InsetX = -( W / 2) ;
		float InsetY = -( H / 2) ;

//		screenRect = new Rect(InsetX, InsetY, W, H);

		if (camTexture != null)
		{
			camTexture.Play();
		}
	}

void OnGUI ()
{

	rawimage.texture = camTexture;
	rawimage.material.mainTexture = camTexture;

	new Thread(o => ScanQr()).Start();

	if (_qrResult != null && _qrResult != "")
	{
		Debug.Log("XXSA: " + _qrResult);
		SceneManager.LoadScene("Resources/rocket/rocket_scene");
	}
}

	private void ScanQr()
	{
		if (run == false)
		{
			return;
		}

		if (!(i < 0))
		{
			i--;
			return;
		}

		Debug.Log("try");

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
					_qrResult = result.Text;
				}
				
			}
		}
		catch (Exception ex)
		{
			Debug.LogWarning(ex.Message);
		}

		i = 75;
	}

	private void OnApplicationQuit()
	{
		run = false;
	}

	private void Update()
	{

	}
}
