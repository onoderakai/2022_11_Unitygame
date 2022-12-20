using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //prefab���擾
    public GameObject enemyPrefab;
    int count = 0;
    //�Q�[���I�u�W�F�N�g���擾
    GameObject player;
    //���������͈�
    Vector3 instantiateRange;
    Vector3 instantiatePos;
    //�X�N���v�g�̎擾
    GameObject mainCameraObj;
    CameraController cameraControllerSc;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        //�͈�
        instantiateRange.x = 10.0f;
        instantiateRange.y = 0.0f;
        instantiateRange.z = 10.0f;
        //�X�N���v�g�̎擾
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!cameraControllerSc.playerEnemyHit)
        {
            count++;
            if (count >= 60)
            {
                count = 0;
                instantiatePos.x = Random.Range(-instantiateRange.x + player.transform.position.x, instantiateRange.x + player.transform.position.x);
                instantiatePos.z = Random.Range(-instantiateRange.z + player.transform.position.z, instantiateRange.z + player.transform.position.z);
                //GameObject enemy = Instantiate(enemyPrefab) as GameObject;
                //enemy.transform.position = instantiatePos;
            }
        }
    }
}
