using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletController : MonoBehaviour
{
    //コンポーネントの取得
    Rigidbody rb;
    //オブジェクトの取得
    GameObject player;
    //弾の速度
    float speed = 70.0f;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントの取得
        rb = GetComponent<Rigidbody>();


        //オブジェクトの取得
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //移動処理
        rb.velocity = transform.forward * -speed;

        if (player != null)
        {
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
        }
    }

    public void SetPlayer(GameObject obj)
    {
        this.player = obj;
    }

    public int GetCount() {
        return count;
    }
}
