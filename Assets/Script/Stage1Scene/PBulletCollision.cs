using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PBulletCollision : MonoBehaviour
{
    string objTag = "";
    //スクリプトの取得
    GameObject mainCamera;
    CameraController cameraController;
    //prefabの取得
    [SerializeField] GameObject particlePrefab;
    [SerializeField] GameObject bulletToBulletParticle;
    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
        mainCamera = GameObject.Find("Main Camera");
        cameraController = mainCamera.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        //当たり判定
        if (objTag == "enemy")
        {
            GameObject particle = Instantiate(particlePrefab) as GameObject;
            particle.transform.position = transform.position;
            particle.GetComponent<ParticleController>().SetSoundType(0);
            cameraController.bulletEnemyHit = true;
            Destroy(gameObject);
        }
        else if (objTag == "Terrain")
        {
            Destroy(gameObject);
        }
        else if (objTag == "enemyBullet")
        {
            GameObject particle = Instantiate(bulletToBulletParticle) as GameObject;
            particle.transform.position = transform.position;
            particle.GetComponent<ParticleController>().SetSoundType(1);
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        objTag = other.gameObject.tag;
    }
}
