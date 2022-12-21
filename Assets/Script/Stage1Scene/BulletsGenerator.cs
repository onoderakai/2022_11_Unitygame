using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsGenerator : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g���擾
    GameObject player;
    public GameObject bulletPrefab;

    [SerializeField] GameObject reloadParticle;
    //�X�N���v�g�̎擾
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //�e��
    public int remainingBullets = 10;
    const int maxRemainingBullets = 10;
    int reloadTime = 0;
    public bool reloadFlag=false;

    int bulletsCoolTime = 0;

   
    //���֘A
    [SerializeField] AudioClip shotSe;
    [SerializeField] AudioClip nothingShotSe;
    [SerializeField] AudioClip reloadSe;
    AudioSource shotSource;


    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("playerEmpty");
        //�R���|�[�l���g���擾
        shotSource = GetComponent<AudioSource>();
        //�X�N���v�g�̎擾
        mainCameraObj = GameObject.Find("Main Camera");
        cameraControllerSc = mainCameraObj.GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!cameraControllerSc.playerEnemyHit)
        {
            if (Input.GetKey(KeyCode.Space) && bulletsCoolTime <= 0 && !reloadFlag)
            {
                if (remainingBullets > 0)
                {
                    remainingBullets--;

                    //����炷
                    shotSource.PlayOneShot(shotSe);

                    bulletsCoolTime = 20;
                    Vector3 pos = player.transform.localPosition;

                    GameObject Shot = Instantiate(bulletPrefab) as GameObject;
                    Shot.transform.position = new Vector3((pos.x), pos.y, (pos.z));
                    Shot.transform.rotation = this.player.transform.rotation;
                }
                else
                {
                    //����炷
                    shotSource.PlayOneShot(nothingShotSe);
                    bulletsCoolTime = 20;
                }

            }
            //�����[�h�t���O
            if (Input.GetKeyDown(KeyCode.R) && !reloadFlag)
            {
                reloadFlag = true;
                reloadParticle.SetActive(true);

            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                reloadFlag = false;
                reloadParticle.SetActive(false);
            }
            //�����[�h����
            if (remainingBullets < maxRemainingBullets && reloadFlag)
            {
                reloadTime++;
                if (reloadTime > 45)
                {
                    reloadTime = 0;
                    remainingBullets++;
                    //����炷
                    shotSource.PlayOneShot(reloadSe);
                }
                
            }
            else if(remainingBullets >= maxRemainingBullets)
            {
                reloadFlag = false;
                reloadParticle.SetActive(false);
            }
            if (bulletsCoolTime > 0)
            {
                bulletsCoolTime--;
            }
        }
        
    }
}
