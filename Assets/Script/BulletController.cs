using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //コンポーネントの取得
    Rigidbody rb;

    //スクリプトの取得
    GameObject mainCamera;
    CameraController cameraController;
    //オブジェクトの取得
    GameObject player;

    string objTag = "";
    //弾の速度
    float speed = 70.0f;
    //prefabの取得
    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントの取得
        rb = GetComponent<Rigidbody>();

        //スクリプトの取得
        mainCamera = GameObject.Find("Main Camera");
        cameraController = mainCamera.GetComponent<CameraController>();
        //オブジェクトの取得
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        rb.velocity = transform.forward * speed;
        //消す処理
        int destroyDis = 200;
        Vector3 dis = player.transform.position - transform.position;
        if (dis.x > destroyDis ||
            dis.y > destroyDis ||
            dis.z > destroyDis ||
            dis.x < -destroyDis ||
            dis.y < -destroyDis ||
            dis.z < -destroyDis)
        {
            Destroy(gameObject);
        }
        //当たり判定
        if(objTag == "enemy")
        {
            GameObject particle = Instantiate(particlePrefab) as GameObject;
            particle.transform.position = transform.position;
            cameraController.bulletEnemyHit = true;
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        objTag=other.gameObject.tag;
    }
}
