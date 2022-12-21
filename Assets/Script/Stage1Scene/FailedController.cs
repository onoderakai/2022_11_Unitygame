using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIに必要

public class FailedController : MonoBehaviour
{
    public Text failedText;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //イージング関連
    Vector3 endPos;
    float t = 0.0f;
    float easeT = 0.0f;
    //通ったフラグ
    bool isFailedText = false;

    // Start is called before the first frame update
    void Start()
    {
        endPos = Vector3.zero;
        //スクリプトの取得
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraControllerSc.playerEnemyHit)
        {
            
            failedText.enabled = true;

            if (transform.localPosition.y > endPos.y && !isFailedText)
            {
                t += 0.05f;
                easeT = t * t;
                transform.Translate(0.0f, -easeT, 0.0f);
            }
            else
            {
                isFailedText = true;
                transform.localPosition = endPos;
            }
        }
        else
        {
            failedText.enabled = false;
        }
    }
    public bool GetIsFailedText()
    {
        return isFailedText;
    }
}
