using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EBulletsGenerator : MonoBehaviour
{
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController mainCameraSc;

    public GameObject enemyBulletPrefab;
    int count = 0;
    int bulletCount = 0;
    int coolTime = 0;

    int atackType = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.mainCameraObj = GameObject.Find("Main Camera");
        this.mainCameraSc = mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.mainCameraSc.playerEnemyHit)
        {
            if (coolTime <= 0)
            {
                count++;
            }
            else
            {
                coolTime--;
            }
            if (count >= 5 && coolTime <= 0 && atackType >= 0 && atackType < 4)
            {
                bulletCount++;
                count = 0;
                GameObject bullet = Instantiate(enemyBulletPrefab) as GameObject;
                Vector3 instantiatePos = new Vector3(transform.position.x, transform.position.y + 13.0f, transform.position.z);
                bullet.transform.position = instantiatePos;
                bullet.transform.rotation = transform.rotation;
                bullet.GetComponent<EBulletController>().SetAtackType(atackType);
                if(bulletCount > 5)
                {
                    int maxAtackType = 5;
                    atackType = Random.Range(0, maxAtackType) % maxAtackType;
                    bulletCount = 0;
                    coolTime = 45;
                }
            }
            else if(coolTime <= 0 && atackType >= 4)
            {
                count = 0;
                GameObject bullet = Instantiate(enemyBulletPrefab) as GameObject;
                Vector3 instantiatePos = new Vector3(transform.position.x, transform.position.y + 13.0f, transform.position.z);
                bullet.transform.position = instantiatePos;
                bullet.transform.rotation = transform.rotation;
                bullet.GetComponent<EBulletController>().SetAtackType(atackType);
                coolTime = 45;
                atackType = Random.Range(0, 4) % 4;
            }
        }
    }
}
