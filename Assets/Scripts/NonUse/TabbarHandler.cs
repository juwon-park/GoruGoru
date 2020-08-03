using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.Experimental.UIElements;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


//하단바, 팝업 관리

public class TabbarHandler : MonoBehaviour
{
    public GameObject exitpopup, homepopup, palacepopup, mappopup;
   
    public static int maploadindex = 0;


    // Start is called before the first frame update
    void Awake()
    {
       
        if (exitpopup != null) { exitpopup.SetActive(false); }
        if (homepopup != null) { homepopup.SetActive(false); }
        if (palacepopup != null) { palacepopup.SetActive(false); }
        if (mappopup != null) { mappopup.SetActive(false); }


    }

    /*
    void ButtonAddListener()
    {
        Homebutton.onClick.AddListener(HomeButtonClick);
        LocationButton.onClick.AddListener(LocationButtonClick);
        MapButton.onClick.AddListener(MapButtonClick);
        CameraButton.onClick.AddListener(CameraButtonClick);

        HomeYesButton.onClick.AddListener(Home_YesClick);
        HomeNoButton.onClick.AddListener(Home_Noclick);

        ExitButton.onClick.AddListener(ExitClick);
        ExitYesButton.onClick.AddListener(ExitYesClick);
        ExitNoButton.onClick.AddListener(ExitNoclick);
    }
    */

    //홈_X 종료버튼
	public void ExitClick(){exitpopup.SetActive(true);}     //종료버튼 => 종료팝업
	public void ExitYesClick(){Application.Quit();}               //예 => 어플종료
	public void ExitNoclick(){exitpopup.SetActive(false);}        //아니오 => 종료팝업끄기

    //하단바
	public void HomeButtonClick(){homepopup.SetActive(true);}    //홈버튼 => 홈팝업
	public void Home_YesClick(){SceneManager.LoadScene(0);}   //홈팝업 예 -> 홈이동
	public void Home_Noclick(){homepopup.SetActive(false);}   //홈팝업   아니오 -> 홈팝업끄기
	public void LocationButtonClick(){SceneManager.LoadScene(2);} //현재위치버튼 => 현재위치로 이동
	public void MapButtonClick(){SceneManager.LoadScene(1);  }      //지도버튼 => 지도로 이동
	public void CameraButtonClick(){SceneManager.LoadScene(3);}   //카메라버튼 => 카메라로 이동


    //닫아줄때
    public void MapButtonClickreload() {


        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);

        //SceneManager.LoadScene(1);

        //Application.LoadLevel(Application.loadedLevel);

        //Get current scene name 
        //string scene = SceneManager.GetActiveScene().name;
        //Load it 
        //  SceneManager.LoadScene(scene, LoadSceneMode.Single);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        //  SceneManager.LoadScene(4);

    }

    //다른전각팝업
    public void OtherClick() { mappopup.SetActive(true);}
    public void OtherNoClick() { mappopup.SetActive(false); }

    //전각 팝업
    public void PalaceClick() { palacepopup.SetActive(true); }  
    public void NaviButtonClick() {
        maploadindex++;
        SceneManager.LoadScene(4);
    }   //팝업_길안내버튼 => 길안내화면
    public void ExplainButtonClick() { SceneManager.LoadScene(5); } //팝업_설명버튼 => 설명화면
    public void DismissButtonClick() { palacepopup.SetActive(false); } //팝업_X버튼 => 팝업끄기


}
