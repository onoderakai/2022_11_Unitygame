using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBulletCollision : MonoBehaviour
{
    string objTag = "";
    //スクリプトの取得
    GameObject mainCamera;
    CameraController cameraController;
    //prefabの取得
    public GameObject particlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
        mainCamera = GameObject.Find("Main Camera");
        cameraController = mainCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        //当たり判定
        if (objTag == "enemy")
        {
            GameObject particle = Instantiate(particlePrefab) as GameObject;
            particle.transform.position = transform.position;
            cameraController.bulletEnemyHit = true;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        objTag = other.gameObject.tag;
    }
}
