using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletController : MonoBehaviour
{
    //�R���|�[�l���g�̎擾
    Rigidbody rb;
    //�I�u�W�F�N�g�̎擾
    GameObject player;
    //�e�̑��x
    float speed = 70.0f;
    private int count = 0;
    float theta = 0.1f;
    //�U���̎��
    int atackType = 0;

    //��]�̑傫��
    float circleSize = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̎擾
        rb = GetComponent<Rigidbody>();


        //�I�u�W�F�N�g�̎擾
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����
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
            //��������
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
