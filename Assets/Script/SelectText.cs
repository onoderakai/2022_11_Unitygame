using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�ɕK�v

public class SelectText : MonoBehaviour
{
    //�e�L�X�g���擾
    Text selectText;
    //�X�N���v�g�̎擾
    GameObject failedObj;
    FailedController failedSc;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        selectText = GetComponent<Text>();
        //�X�N���v�g�̎擾
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
