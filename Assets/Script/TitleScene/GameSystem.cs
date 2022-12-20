using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移に必要

public class GameSystem : MonoBehaviour
{

    //イージングフラグ
    [SerializeField] private bool easeFlag=false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
    }

    // Update is called once per frame
    void Update()
    {
        if (easeFlag)
        {
            GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
        }
    }
    
    //ボタンを押したらシーン遷移
    public void StartGame()
    {
        easeFlag = true;

        //SceneManager.LoadScene("ExplainScene");
    }
    
    
}
