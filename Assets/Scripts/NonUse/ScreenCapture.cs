using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.IO;

public class ScreenCapture : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public Camera screenShotCamera;

    bool isBtnDown = false;


	void Start()
	{
		/*
		if (!System.IO.Directory.Exists (Application.persistentDataPath + "/screenshots"))
			System.IO.Directory.CreateDirectory (Application.persistentDataPath + "/screenshots");
		*/
	}

	public string ScreenShotName(int width, int height)
	{
		return string.Format("{0}/screenshots/screen_{1}*{2}_{3}.png",
			Application.persistentDataPath, width, height,
			//Application.productName, width, height,
			System.DateTime.Now.ToString("yyyy-MM-dd_hh-mm-ss"));
	}


	public void OnPointerDown(PointerEventData data)
	{
		isBtnDown = true;
	}

	public void OnPointerUp(PointerEventData data)
	{
		isBtnDown = false;
	}


	IEnumerator Rendering() {

		yield return new WaitForEndOfFrame ();

		string date = System.DateTime.Now.ToString ("yyyy-MM-dd_HH-mm-ss");
		string myFilename = "screenshot_" + date + ".png";
		string myDefaultLocation = Application.persistentDataPath + "/" + myFilename;
		string myFolderLocation = "/storage/emulated/0/DCIM/경복궁AR/";
		string myScreenShotLocation = myFolderLocation + myFilename;

		if (!System.IO.Directory.Exists (myFolderLocation)) {
			System.IO.Directory.CreateDirectory (myFolderLocation);
		}

		byte[] imgBytes; //스크린샷을 Byte로 저장(Texture2D use)

		//screenshot size 조절(capture without UI)
		Rect image = new Rect (0, 0, Screen.width, Screen.height);
		RenderTexture renderTexture = new RenderTexture (Screen.width, Screen.height, 24);
		Texture2D texture = new Texture2D (Screen.width, Screen.height, TextureFormat.RGB24, false);

		screenShotCamera.targetTexture = renderTexture;
		screenShotCamera.Render ();

		RenderTexture.active = renderTexture;

		texture.ReadPixels (new Rect (0, 0, Screen.width, Screen.height), 0, 0); //현재 화면을 pixel단위로 읽어옴
		texture.Apply (); //읽은 것 적용

		screenShotCamera.targetTexture = null;
		RenderTexture.active = null;

		imgBytes = texture.EncodeToJPG ();  //JPG 형식으로 인코딩 해서 저장

		Destroy (renderTexture);

		System.IO.File.WriteAllBytes(myScreenShotLocation, imgBytes);

		isBtnDown = false;

		AndroidJavaClass classPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"); 
		AndroidJavaObject objActivity = classPlayer.GetStatic<AndroidJavaObject>("currentActivity"); 
		AndroidJavaClass classUri = new AndroidJavaClass("android.net.Uri"); 
		AndroidJavaObject objIntent = new AndroidJavaObject("android.content.Intent", new object[2] { "android.intent.action.MEDIA_SCANNER_SCAN_FILE", classUri.CallStatic<AndroidJavaObject>("parse", "file://" + myScreenShotLocation) }); 
		objActivity.Call("sendBroadcast", objIntent); 
	}

	public void OnClick()
	{
		StartCoroutine (Rendering());
	}
}


