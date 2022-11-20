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
        rb.velocity = transform.forward * -speed;
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
