using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //이 함수인가? 로딩 완료되면,,넘어가는..?
    public void OnLevelWasLoaded(int level)
    {
        
    }

    
    public void Tmpbutton_Click()
    {
        SceneManager.LoadScene(1);
    }
}
