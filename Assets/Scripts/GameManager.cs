using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    private int GainCarrotCnt;     //모은 당근 수 저장
    private bool IsWatchTutoial; //튜토리얼 봤는지 저장,, 안ㄴ쓴대요..
    private int GainDishCnt ;   //리워드 저장

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // 1. 게임이 로드 되자마자 PlayerPrefs 정보들을 가지고 온다.
        Load_PlayerPrefs();

    }

    private void Load_PlayerPrefs()
    {
        //초기화
        GainCarrotCnt = 0;
        IsWatchTutoial = false;
        GainDishCnt = 0;

        //불러오기
        if (PlayerPrefs.HasKey("GainCarrotCnt"))
        {
            GainCarrotCnt = PlayerPrefs.GetInt("GainCarrotCnt");
        }

        if (PlayerPrefs.HasKey("IsWatchTutoial"))
        {
            IsWatchTutoial = true;
        }

        if (PlayerPrefs.HasKey("GainDishCnt"))
        {
            GainDishCnt = PlayerPrefs.GetInt("GainCarrotCnt");
        }

    }

    public void Increase_GainCarrotCnt()
    {
        GainCarrotCnt = (++GainCarrotCnt) % 5;
        PlayerPrefs.SetInt("GainCarrotCnt", GainCarrotCnt);
    }

    public int Get_GainCarrotCnt()
    {
        return GainCarrotCnt;
    }

}