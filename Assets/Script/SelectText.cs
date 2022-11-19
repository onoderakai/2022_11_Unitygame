using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIに必要

public class SelectText : MonoBehaviour
{
    //テキストを取得
    Text selectText;
    //スクリプトの取得
    GameObject failedObj;
    FailedController failedSc;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectText = GetComponent<Text>();
        //スクリプトの取得
        failedObj = GameObject.Find("failedText");
        failedSc=failedObj.GetComponent<FailedController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (failedSc.isFailedText)
        {
            count++;
            if(count >= 10)
            {
                count = 0;
                if (!selectText.enabled)
                {
                    selectText.enabled = true;
                }
                else
                {
                    selectText.enabled = false;
                }
            }
        }
        else
        {
            selectText.enabled = false;
        }
    }
}
