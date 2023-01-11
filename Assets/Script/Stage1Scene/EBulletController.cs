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
    float theta = 0.1f;
    //攻撃の種類
    int atackType = 0;

    //回転の大きさ
    float circleSize = 0.0f;

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
        if (atackType == 0)
        {
            rb.velocity = transform.forward * -speed;
            transform.Translate(Mathf.Cos(theta) * circleSize, Mathf.Sin(theta) * circleSize, 0);
            theta += 0.1f;
            circleSize += 0.01f;
        }
        if (atackType == 1)
        {
            rb.velocity = transform.forward * -speed;
            transform.Translate(Mathf.Cos(theta) * circleSize, Mathf.Sin(theta) * circleSize, 0);
            theta -= 0.1f;
            circleSize += 0.01f;
        }
        else if(atackType == 2)
        {
            rb.velocity = transform.forward * -speed;
            transform.Translate(Mathf.Cos(theta) * circleSize, 0, 0);
            theta += 0.1f;
            circleSize += 0.01f;
        }
        else if (atackType == 3)
        {
            rb.velocity = transform.forward * -speed;
            transform.Translate(Mathf.Cos(theta) * circleSize, 0, 0);
            theta -= 0.1f;
            circleSize += 0.01f;
        }
        else if (atackType == 4)
        {
            rb.velocity = transform.forward * -speed * 10;
            Vector3 size = transform.localScale;
            if(size.z < 500.0f)
            {
                size.z += speed;
            }
            transform.localScale = size;
        }

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
    public void SetAtackType(int atackType)
    {
        this.atackType = atackType;
    }

    public int GetCount() {
        return count;
    }
}
