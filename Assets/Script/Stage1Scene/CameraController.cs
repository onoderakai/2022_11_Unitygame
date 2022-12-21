using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //変数などの宣言

    //最初のローカル座標を保存
    Vector3 pos;
    //揺れの大きさ
    Vector3 vibration = Vector3.zero;
    //揺れの最大値
    Vector2 maxVibration;
    Vector2 maxDamageVibration;
    //揺れ幅
    Vector2 vibrationRange = Vector2.zero;
    Vector2 pHitVibrationRange = Vector2.zero;

    //パブリック変数
    public bool bulletEnemyHit = false;
    public bool playerEnemyHit = false;
    bool isPlayerEnemyHit = false;
    //揺れている時間
    int vibrationTime = 0;
    int pHitVibrationTime = 0;
    //揺れている最大時間
    int maxVibrationTime;
    //何回通ったか
    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        //変数などの初期化

        //揺れの最大値
        maxVibration.x = 1.0f;
        maxVibration.y = 1.0f;
        maxDamageVibration.x = 6.0f;
        maxDamageVibration.y = 6.0f;
        //揺れている最大時間
        maxVibrationTime = 60;

        //最初のローカル座標を保存
        pos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //小さいシェイク
        if (!playerEnemyHit)
        {
            //弾が敵に当たったら
            if (bulletEnemyHit)
            {
                vibrationTime = maxVibrationTime;
                bulletEnemyHit = false;
                vibrationRange = maxVibration;
            }
            //敵に弾が当たった時のシェイク
            if (vibrationTime > 0)
            {
                vibrationTime--;

                vibration.x = Random.Range(-vibrationRange.x, vibrationRange.x);
                vibration.y = Random.Range(-vibrationRange.y, vibrationRange.y);
                //カメラ位置を戻す
                transform.localPosition = pos;
                //カメラ位置をシェイク
                transform.Translate(vibration.x, vibration.y, 0.0f);

                if (vibrationRange.x > 0)
                {
                    vibrationRange.x -= 0.1f;
                }
                if (vibrationRange.y > 0)
                {
                    vibrationRange.y -= 0.1f;
                }
                //揺れ幅がゼロになったら
                else
                {
                    //カメラ位置を戻す
                    transform.localPosition = pos;
                }
            }
        }
       
        
        //プレイヤーが敵に当たったら
        if (playerEnemyHit && !isPlayerEnemyHit)
        {
            pHitVibrationTime = 120;
            isPlayerEnemyHit = true;
            pHitVibrationRange = maxDamageVibration;
        }
        
        //プレイヤーに弾が当たった時のシェイク
        if (pHitVibrationTime > 0 && playerEnemyHit)
        {
            count++;
            pHitVibrationTime--;
            int maxCount = 10;
            if(count >= maxCount)
            {
                count = 0;
                vibration.x = Random.Range(-pHitVibrationRange.x, pHitVibrationRange.x);
                vibration.y = Random.Range(-pHitVibrationRange.y, pHitVibrationRange.y);
                //カメラ位置を戻す
                transform.localPosition = pos;
                
            }

            //カメラ位置をシェイク
            if (count < maxCount / 2)
            {
                transform.Translate(vibration.x / 3.0f, vibration.y / 3.0f, 0.0f);
            }
            else
            {
                transform.Translate(-vibration.x / 3.0f, -vibration.y / 3.0f, 0.0f);
            }
           

            if (pHitVibrationRange.x > 0)
            {
                pHitVibrationRange.x -= 0.1f;
            }
            if (pHitVibrationRange.y > 0)
            {
                pHitVibrationRange.y -= 0.1f;
            }
            //揺れ幅がゼロになったら
            else
            {
                //カメラ位置を戻す
                transform.localPosition = pos;
            }
        }

    }
}
