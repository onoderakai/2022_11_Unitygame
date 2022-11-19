using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    //�R���|�[�l���g�̎擾
    Rigidbody rb;

    //�X�N���v�g�̎擾
    GameObject mainCamera;
    CameraController cameraController;
    //�I�u�W�F�N�g�̎擾
    GameObject player;

    string objTag = "";
    //�e�̑��x
    float speed = 70.0f;
    //prefab�̎擾
    public GameObject particlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̎擾
        rb = GetComponent<Rigidbody>();

        //�X�N���v�g�̎擾
        mainCamera = GameObject.Find("Main Camera");
        cameraController = mainCamera.GetComponent<CameraController>();
        //�I�u�W�F�N�g�̎擾
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�ړ�����
        rb.velocity = transform.forward * speed;
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
        //�����蔻��
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
