using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PCollision : MonoBehaviour
{
    //hp
    [SerializeField] private int hp = 0;

    string objTag;
    private bool isHit = false;
    //�X�N���v�g�̎擾
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //prefab�̎擾
    [SerializeField]
    GameObject particlePrefab;
    [SerializeField]
    GameObject damageParticlePrefab;
    //�Q�[���I�u�W�F�N�g���擾
    GameObject playerEmpty;

    //�U�������������ꏊ
    Vector3 hitPos;

    //HP�𓾂�
    HpManager hpManagerSc;

    // Start is called before the first frame update
    void Start()
    {
        //�X�N���v�g�̎擾
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();
        //�Q�[���I�u�W�F�N�g���擾
        playerEmpty = GameObject.Find("playerEmpty");

        hpManagerSc = GameObject.Find("HpManager").GetComponent<HpManager>();

        //hp�̏�����
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
                //�΂��o��
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
