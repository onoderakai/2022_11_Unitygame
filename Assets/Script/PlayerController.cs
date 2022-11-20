using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //スクリプトの取得
    GameObject bulletsGeneratorObj;
    BulletsGenerator bulletsGeneratorSc;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
        //スクリプトの取得
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();

        bulletsGeneratorObj = GameObject.Find("BulletsGenerator");
        bulletsGeneratorSc= bulletsGeneratorObj.GetComponent<BulletsGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!cameraControllerSc.playerEnemyHit)
        {
            if (bulletsGeneratorSc.reloadFlag)
            {
                float speed = 0.05f;
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(0.0f, 0.0f, speed);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-speed, 0.0f, 0.0f);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0.0f, 0.0f, -speed);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(speed, 0.0f, 0.0f);
                }
            }
            else
            {
                float speed = 0.3f;
                if (Input.GetKey(KeyCode.W))
                {
                    transform.Translate(0.0f, 0.0f, speed);
                }
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Translate(-speed, 0.0f, 0.0f);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(0.0f, 0.0f, -speed);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Translate(speed, 0.0f, 0.0f);
                }
            }
           
        }
    }
}
