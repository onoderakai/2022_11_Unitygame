using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移に必要

public class SceneSystem : MonoBehaviour
{
    //スクリプトの取得
    GameObject failedObj;
    FailedController failedSc;
    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
        failedObj = GameObject.Find("failedText");
        failedSc = failedObj.GetComponent<FailedController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (failedSc.isFailedText)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("TitleScene");
            }
        }
    }
}
