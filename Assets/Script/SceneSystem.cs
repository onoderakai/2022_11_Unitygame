using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���J�ڂɕK�v

public class SceneSystem : MonoBehaviour
{
    //�X�N���v�g�̎擾
    GameObject failedObj;
    FailedController failedSc;
    // Start is called before the first frame update
    void Start()
    {
        //�X�N���v�g�̎擾
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
