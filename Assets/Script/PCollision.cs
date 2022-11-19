using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCollision : MonoBehaviour
{
    string objTag;
    //�X�N���v�g�̎擾
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //prefab�̎擾
    public GameObject particlePrefab;
    //�Q�[���I�u�W�F�N�g���擾
    GameObject playerEmpty;

    // Start is called before the first frame update
    void Start()
    {
        //�X�N���v�g�̎擾
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc=mainCameraObj.GetComponent<CameraController>();
        //�Q�[���I�u�W�F�N�g���擾
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
