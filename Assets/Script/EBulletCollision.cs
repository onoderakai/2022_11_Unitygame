using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletCollision : MonoBehaviour
{
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController mainCameraSc;

    string objTag;
    // Start is called before the first frame update
    void Start()
    {
        this.mainCameraObj = GameObject.Find("Main Camera");
        this.mainCameraSc=mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(objTag == "Player")
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        objTag=other.gameObject.tag;
    }
}
