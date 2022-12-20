using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移に必要

public class EnemyManager : MonoBehaviour
{
    GameObject[] enemyObj;
    int enemyCount = 0;
    int count = 0;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController mainCameraSc;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCameraObj = GameObject.Find("Main Camera");
        this.mainCameraSc = mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyObj = GameObject.FindGameObjectsWithTag("enemy");
        enemyCount = enemyObj.Length;
        if (enemyCount <= 0 && !mainCameraSc.playerEnemyHit)
        {
            count++;
            if(count >= 60)
            {
                count = 0;
                SceneManager.LoadScene("ClearScene");
            }
            
        }
    }
}
