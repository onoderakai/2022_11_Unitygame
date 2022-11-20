using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsGenerator : MonoBehaviour
{
    //ゲームオブジェクトを取得
    GameObject player;
    public GameObject bulletPrefab;
    //スクリプトの取得
    GameObject mainCameraObj;
    CameraController cameraControllerSc;
    //弾数
    public int remainingBullets = 10;
    const int maxRemainingBullets = 10;
    int reloadTime = 0;
    public bool reloadFlag=false;

    int bulletsCoolTime = 0;

    float rotatedX = 0f;
    float rotatedY = 0f;
    float rotatedZ = 1f;

    public float pRotatedX = 1f;
    public float pRotatedY = 1f;
    public float pRotatedZ = 1f;

    //音関連
    public AudioClip shotSe;
    public AudioClip nothingShotSe;
    AudioSource shotSource;


    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("playerEmpty");
        //コンポーネントを取得
        shotSource = GetComponent<AudioSource>();
        //スクリプトの取得
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

                    //音を鳴らす
                    shotSource.PlayOneShot(shotSe);

                    //打ち直しするごとに角度が変わる
                    Vector3 rotated = new Vector3(rotatedX, rotatedY, rotatedZ);
                    //角度
                    rotated = this.player.transform.rotation * rotated;
                    //パブリックの角度
                    pRotatedX = rotated.x;
                    pRotatedY = rotated.y;
                    pRotatedZ = rotated.z;
                    //ここまで


                    bulletsCoolTime = 20;
                    Vector3 pos = player.transform.localPosition;

                    GameObject Shot = Instantiate(bulletPrefab) as GameObject;
                    Shot.transform.position = new Vector3((pos.x), pos.y, (pos.z));
                    Shot.transform.rotation = this.player.transform.rotation;
                }
                else
                {
                    //音を鳴らす
                    shotSource.PlayOneShot(nothingShotSe);
                    bulletsCoolTime = 20;
                }

            }
            if (Input.GetKeyDown(KeyCode.R) && !reloadFlag)
            {
                reloadFlag = true;

            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                reloadFlag = false;
            }
            if (remainingBullets < maxRemainingBullets && reloadFlag)
            {
                reloadTime++;
                if (reloadTime > 45)
                {
                    reloadTime = 0;
                    remainingBullets++;
                }
            }
            else if(remainingBullets >= maxRemainingBullets)
            {
                reloadFlag = false;
            }
            if (bulletsCoolTime > 0)
            {
                bulletsCoolTime--;
            }
        }
        
    }
}
