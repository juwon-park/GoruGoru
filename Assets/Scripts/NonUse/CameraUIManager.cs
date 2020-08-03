using UnityEngine;
using UnityEngine.UI;

public class CameraUIManager : MonoBehaviour
{
	public RectTransform mainCam, CharCam, Char1, Char2;

	public GameObject charbutton1, gocamScreen,
	KingOriginalObj, KingBackHandObj, KingHandlingObj,
	QueenOriginalObj, QueenBowingObj, QueenWalkObj,
	ServantOriginalObj, OneServantBowingObj, ServantRotateNeckObj, SixServantBowingObj,
	KingQueenGreetingObj, AllGreetingObj;

	public Camera screenShotCamera;

	// Start is called before the first frame update
	void Start()
	{
		//DOTween.Init();

		//mainCam.DOAnchorPos(Vector2.zero, 0f);
		//CharCam.DOAnchorPos(new Vector2(0, -2960), 0.25F);
		charbutton1.GetComponent<Button>().interactable = false;
		//gameobject.SetActive(false);
		KingOriginalObj.SetActive(false);
		KingBackHandObj.SetActive (false);
		KingHandlingObj.SetActive (false);
		QueenOriginalObj.SetActive (false);
		QueenBowingObj.SetActive (false);
		QueenWalkObj.SetActive (false);
		ServantOriginalObj.SetActive (false);
		ServantRotateNeckObj.SetActive (false);
		OneServantBowingObj.SetActive (false);
		SixServantBowingObj.SetActive (false);
		KingQueenGreetingObj.SetActive (false);
		AllGreetingObj.SetActive (false);
	}
		
	public void CharacterButton()
	{
		//mainCam.DOAnchorPos(new Vector2(0, -2960), 0.25f);
		//CharCam.DOAnchorPos(new Vector2(0, 0), 0.25f);
	}
		
	public void CloseCharButton()
	{
		//mainCam.DOAnchorPos(new Vector2(0, 0), 0.25f);
		//CharCam.DOAnchorPos(new Vector2(0, -2960), 0.25f);
		//gocamScreen.SetActive (false);
	}

	public void Page1Click() {

		//Char1.DOAnchorPos(new Vector2(0, 452), 0.0f);
		//Char2.DOAnchorPos(new Vector2(1440, 452), 0.0f);
	}

	public void Page2Click()
	{
		//Char1.DOAnchorPos(new Vector2(1440, 452), 0.0f);
		//Char2.DOAnchorPos(new Vector2(0, 452), 0.0f);
	}
		
	public void KingOriginalControl(Toggle toggle)
	{
		if(toggle.isOn)
		{
			KingOriginalObj.SetActive(true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕_오리지널");
        }

		else
		{
			KingOriginalObj.SetActive(false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕_오리지널");
        }
	}

	public void KingBackHandControl(Toggle toggle)
	{
		if (toggle.isOn)
		{
			KingBackHandObj.SetActive(true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕_뒷짐");

        }
		else
		{
			KingBackHandObj.SetActive(false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕_뒷짐");
        }
	}

	public void KingHandlingControl(Toggle toggle)
	{
		if (toggle.isOn)
		{
			KingHandlingObj.SetActive(true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕_손인사");
        }
		else
		{
			KingHandlingObj.SetActive(false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕_손인사");
        }
	}

	public void QueenOriginalControl(Toggle toggle)
	{
		if (toggle.isOn) {
			QueenOriginalObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕비_오리지널");
        } else {
			QueenOriginalObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕비_오리지널");
        }
	}

	public void QueenBowingControl(Toggle toggle)
	{
		if (toggle.isOn) {
			QueenBowingObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕비_고개숙이기");
        } else {
			QueenBowingObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕비_고개숙이기");
        }
	}

	public void QueenWalkControl(Toggle toggle)
	{
		if (toggle.isOn) {
			QueenWalkObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕비_걷기");
        } else {
			QueenWalkObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕비_걷기");
        }
	}

	public void ServantOriginalControl(Toggle toggle)
	{
		if (toggle.isOn)
		{
			ServantOriginalObj.SetActive(true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_신하_오리지널");
        }
		else
		{
			ServantOriginalObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_신하_오리지널");
        }
	}

	public void ServantHipControl(Toggle toggle)
	{
		if (toggle.isOn)
		{
			ServantRotateNeckObj.SetActive(true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_신하_고개빼꼼");
        }
		else
		{
			ServantRotateNeckObj.SetActive(false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_신하_고개빼꼼");
        }
	}

	public void OneServantBowingControl(Toggle toggle)
	{
		if (toggle.isOn) {
			OneServantBowingObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_신하_고개숙이기");
        } else {
			OneServantBowingObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_신하_고개숙이기");
        }
	}

	public void SixServantBowingControl(Toggle toggle)
	{
		if (toggle.isOn) {
			SixServantBowingObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_신하거느리기");
        } else {
			SixServantBowingObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_신하거느리기");
        }
	}

	public void KingQueenGreetingControl(Toggle toggle)
	{
		if (toggle.isOn) {
			KingQueenGreetingObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕&왕비");
        } else {
			KingQueenGreetingObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕&왕비");
        }
	}

	public void AllGreetingControl(Toggle toggle)
	{
		if (toggle.isOn) {
			AllGreetingObj.SetActive (true);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/character_stroke/캐릭터_왕&왕비&신하");
        } else {
			AllGreetingObj.SetActive (false);
            toggle.GetComponent<Image>().sprite = Resources.Load<Sprite>("camera/char/캐릭터_왕&왕비&신하");
        }
	}
}
