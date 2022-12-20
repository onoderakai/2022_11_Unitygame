using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCollision : MonoBehaviour
{
    //hp
    [SerializeField] private int hp = 0;

    string objTag;
    private bool isHit = false;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //prefabの取得
    [SerializeField]
    GameObject particlePrefab;
    [SerializeField]
    GameObject damageParticlePrefab;
    //ゲームオブジェクトを取得
    GameObject playerEmpty;

    //攻撃が当たった場所
    Vector3 hitPos;

    //HPを得る
    HpManager hpManagerSc;

    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();
        //ゲームオブジェクトを取得
        playerEmpty = GameObject.Find("playerEmpty");

        hpManagerSc = GameObject.Find("HpManager").GetComponent<HpManager>();

        //hpの初期化
        hp = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            if (objTag == "enemy" ||
            objTag == "enemyBullet")
            {
                isHit = false;
                hp = hpManagerSc.GetHpCount();
                hp--;
                hpManagerSc.SetHpCount(hp);
                if (hp <= 0)
                {
                    GameObject particle = Instantiate(particlePrefab) as GameObject;
                    particle.transform.position = playerEmpty.transform.position;
                    cameraControllerSc.playerEnemyHit = true;
                    Destroy(gameObject);

                }
                //火が出る
                GameObject damageParticle = Instantiate(damageParticlePrefab) as GameObject;
                damageParticle.transform.position = hitPos;
                damageParticle.transform.parent = playerEmpty.transform;
                
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        objTag = other.gameObject.tag;
        isHit = true;
        hitPos = other.ClosestPointOnBounds(this.transform.position);
    }
}
