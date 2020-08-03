using UnityEngine;
# if PLATFORM_ANDROID
using UnityEngine.Android;
# endif

public class PermissionsRationaleDialog : MonoBehaviour
{
    const int kDialogWidth = 600;
    const int kDialogHeight = 200;
    private bool windowOpen = true;

    void DoMyWindow(int windowID)
    {
        //GUI.Label(new Rect(20, 40, kDialogWidth - 40, kDialogHeight - 100), "Please let me use the  camera.");
        //GUI.Button(new Rect(20, kDialogHeight - 60, 200, 40), "No");
        if (GUI.Button(new Rect(kDialogWidth - 220, kDialogHeight - 60, 200, 40), "Yes"))
        {
#if PLATFORM_ANDROID
            Permission.RequestUserPermission(Permission.Camera);
#endif
            windowOpen = false;
        }
    }

    void OnGUI()
    {
        if (windowOpen)
        {    
            Rect rect = new Rect((Screen.width / 2) - (kDialogWidth / 2), (Screen.height / 2) - (kDialogHeight / 2), kDialogWidth, kDialogHeight);
            GUI.ModalWindow(0, rect, DoMyWindow, "Permissions Request Dialog");
        }
    }
}