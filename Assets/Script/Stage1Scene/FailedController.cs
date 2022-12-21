using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�ɕK�v

public class FailedController : MonoBehaviour
{
    public Text failedText;
    //�X�N���v�g�̎擾
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //�C�[�W���O�֘A
    Vector3 endPos;
    float t = 0.0f;
    float easeT = 0.0f;
    //�ʂ����t���O
    bool isFailedText = false;

    // Start is called before the first frame update
    void Start()
    {
        endPos = Vector3.zero;
        //�X�N���v�g�̎擾
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
