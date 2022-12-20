using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    //prefabを取得
    public GameObject enemyPrefab;
    int count = 0;
    //ゲームオブジェクトを取得
    GameObject player;
    //生成される範囲
    Vector3 instantiateRange;
    Vector3 instantiatePos;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        //範囲
        instantiateRange.x = 10.0f;
        instantiateRange.y = 0.0f;
        instantiateRange.z = 10.0f;
        //スクリプトの取得
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
