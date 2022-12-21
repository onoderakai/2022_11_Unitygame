using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移に必要

public class GameSystem : MonoBehaviour
{

    //イージングフラグ
    [SerializeField] private bool easeFlag = false;
    //ゲームオブジェクトを取得
    [SerializeField]
    GameObject sceneChangeObj;
    //スクリプトを取得
    SceneChangeSc sceneChangeSc;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
        this.sceneChangeObj = GameObject.Find("EaseBg");
        sceneChangeObj.SetActive(false);
        sceneChangeSc = sceneChangeObj.GetComponent<SceneChangeSc>();
    }

    // Update is called once per frame
    void Update()
    {
        if (easeFlag)
        {
            GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
        }
        if (sceneChangeSc.GetEaseComplete())
        {
            sceneChangeSc.SetEaseComplete(false);
            SceneManager.LoadScene(1);
            
        }
    }

    //ボタンを押したらシーン遷移
    public void StartGame()
    {
        easeFlag = true;
        sceneChangeObj.SetActive(true);
    }


}
