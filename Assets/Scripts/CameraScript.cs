using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    static WebCamTexture backCam;

    // Start is called before the first frame update
    void Start()
    {
        GoogleARCore.AndroidPermissionsManager.RequestPermission("android.permission.CAMERA");

        if (backCam == null)
            backCam = new WebCamTexture();

        GetComponent<Renderer>().material.mainTexture = backCam;

        if (!backCam.isPlaying)
            backCam.Play();
        
    }
}
