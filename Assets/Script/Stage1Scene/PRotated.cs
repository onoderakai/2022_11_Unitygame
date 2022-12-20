using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PRotated : MonoBehaviour
{
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //回転速度
    float rotateSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!cameraControllerSc.playerEnemyHit)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(0, rotateSpeed, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(0, -rotateSpeed, 0);
            }

        }

    }
}
