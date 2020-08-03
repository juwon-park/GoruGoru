using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFairyController : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> CarrotUIList;

    [SerializeField]
    private GameObject GainStarPanel;

    // 기능 정의  
    // 1. GameFairy와 다른 오브젝트 (Carrot3D, 벽, 장애물) 충돌
    // 2. Carrot_Cnt + 1 , 충돌한 Carrot3D SetActive(false), CarrotUI SetActive(true), PlayerPrefs에 저장
    // PlayerPrefs.SetInt("Carrot_cnt", Carrot_cnt);
    // 3. Carrot_Cnt가 5면 별 획득 + 캐릭터 모션 + 리워드 이동

    private void OnTriggerEnter(Collider other)
    {
        //부딪힌 태그가 당근이면 당근 파괴하고 increase_GainCarrotCnt();
        Debug.Log("당근과 충돌");
        CollideWithCarrot3D();
        Destroy(other.gameObject);  //other.gameObject.SetActive(false);                 
                    
    }

    public void CollideWithCarrot3D()    //당근과 충돌 시
    {
        GameManager.instance.Increase_GainCarrotCnt();
        int GainCarrotCnt = GameManager.instance.Get_GainCarrotCnt();

        // 별 획득 시      
        if (GainCarrotCnt == 0)
        {
            //마지막 당근 SetActive
            CarrotUIList[CarrotUIList.Count-1].SetActive(true);

            //여기서 걸리는 시간만큼 딜레이 좀 걸어주는 게 나을 듯 함 (5개 채워진 거 보이게 + 캐릭터 모션 재생 등등)
            GainStarPanel.SetActive(true);

            //딜레이 걸었다가 초기화할지, 그냥 이 반복문을 없앨지 (리워드로 바로 이동하면 반복문 그냥 없애면 됨)
            //for (int i = 0; i < 5; i++)
            //{
            //    CarrotUIList[i].SetActive(false);
            //}

            ////리워드 씬으로 이동
            SceneManager.LoadScene(4);

        }
        else
        {
            CarrotUIList[GainCarrotCnt-1].SetActive(true);
        }
 
    }
}
