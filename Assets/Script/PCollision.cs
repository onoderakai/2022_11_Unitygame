using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCollision : MonoBehaviour
{
    string objTag;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //prefabの取得
    public GameObject particlePrefab;
    //ゲームオブジェクトを取得
    GameObject playerEmpty;

    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc=mainCameraObj.GetComponent<CameraController>();
        //ゲームオブジェクトを取得
        playerEmpty = GameObject.Find("playerEmpty");
    }

    // Update is called once per frame
    void Update()
    {
        if(objTag == "enemy")
        {
            GameObject particle = Instantiate(particlePrefab) as GameObject;
            particle.transform.position = playerEmpty.transform.position;
            cameraControllerSc.playerEnemyHit = true;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        objTag = other.gameObject.tag;
    }
}
