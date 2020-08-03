using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartFairyController : MonoBehaviour
{
    public Text txtFeedBack;

    [SerializeField]
    private List<GameObject> VisibleList;
  
    [SerializeField]
    private List<GameObject> Carrot3DList;

    [SerializeField]
    private List<GameObject> UnvisibleList;

    public void OnMouseDown()
    {
        //1. AR 게임판 SetActive (게임요정, 배경,조이스틱 UI 등)
        for (int i = 0; i < VisibleList.Count; i++)
        {
            VisibleList[i].SetActive(true);
        }

        //2. 저장된 당근 수 만큼만 SetActive + 난수로 당근 위치 변경해주기           
        for (int i = 0; i < 5 - GameManager.instance.Get_GainCarrotCnt(); i++)
        {
            Carrot3DList[i].SetActive(true);

            //x : -0.39670 ~ 0.08015 , y : 0.28772 (고정), z: -0.82376 ~ -1.30600
            Carrot3DList[i].transform.localPosition = new Vector3(Random.Range(-0.39670f, 0.08015f), 0.28772f, Random.Range(-1.30600f, -0.82376f));       
        }

        //3. 화면에서 안 보이게 할 목록 처리
        for (int i = 0; i < UnvisibleList.Count; i++)
        {
            UnvisibleList[i].SetActive(false);
        }
    }


}
