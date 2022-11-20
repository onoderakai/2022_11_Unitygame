using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBulletCollision : MonoBehaviour
{
    string objTag = "";
    //�X�N���v�g�̎擾
    GameObject mainCamera;
    CameraController cameraController;
    //prefab�̎擾
    public GameObject particlePrefab;
    // Start is called before the first frame update
    void Start()
    {
        //�X�N���v�g�̎擾
        mainCamera = GameObject.Find("Main Camera");
        cameraController = mainCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        //�����蔻��
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
