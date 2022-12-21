using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //�ϐ��Ȃǂ̐錾

    //�ŏ��̃��[�J�����W��ۑ�
    Vector3 pos;
    //�h��̑傫��
    Vector3 vibration = Vector3.zero;
    //�h��̍ő�l
    Vector2 maxVibration;
    Vector2 maxDamageVibration;
    //�h�ꕝ
    Vector2 vibrationRange = Vector2.zero;
    Vector2 pHitVibrationRange = Vector2.zero;

    //�p�u���b�N�ϐ�
    public bool bulletEnemyHit = false;
    public bool playerEnemyHit = false;
    bool isPlayerEnemyHit = false;
    //�h��Ă��鎞��
    int vibrationTime = 0;
    int pHitVibrationTime = 0;
    //�h��Ă���ő厞��
    int maxVibrationTime;
    //����ʂ�����
    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        //�ϐ��Ȃǂ̏�����

        //�h��̍ő�l
        maxVibration.x = 1.0f;
        maxVibration.y = 1.0f;
        maxDamageVibration.x = 6.0f;
        maxDamageVibration.y = 6.0f;
        //�h��Ă���ő厞��
        maxVibrationTime = 60;

        //�ŏ��̃��[�J�����W��ۑ�
        pos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //�������V�F�C�N
        if (!playerEnemyHit)
        {
            //�e���G�ɓ���������
            if (bulletEnemyHit)
            {
                vibrationTime = maxVibrationTime;
                bulletEnemyHit = false;
                vibrationRange = maxVibration;
            }
            //�G�ɒe�������������̃V�F�C�N
            if (vibrationTime > 0)
            {
                vibrationTime--;

                vibration.x = Random.Range(-vibrationRange.x, vibrationRange.x);
                vibration.y = Random.Range(-vibrationRange.y, vibrationRange.y);
                //�J�����ʒu��߂�
                transform.localPosition = pos;
                //�J�����ʒu���V�F�C�N
                transform.Translate(vibration.x, vibration.y, 0.0f);

                if (vibrationRange.x > 0)
                {
                    vibrationRange.x -= 0.1f;
                }
                if (vibrationRange.y > 0)
                {
                    vibrationRange.y -= 0.1f;
                }
                //�h�ꕝ���[���ɂȂ�����
                else
                {
                    //�J�����ʒu��߂�
                    transform.localPosition = pos;
                }
            }
        }
       
        
        //�v���C���[���G�ɓ���������
        if (playerEnemyHit && !isPlayerEnemyHit)
        {
            pHitVibrationTime = 120;
            isPlayerEnemyHit = true;
            pHitVibrationRange = maxDamageVibration;
        }
        
        //�v���C���[�ɒe�������������̃V�F�C�N
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
                //�J�����ʒu��߂�
                transform.localPosition = pos;
                
            }

            //�J�����ʒu���V�F�C�N
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
            //�h�ꕝ���[���ɂȂ�����
            else
            {
                //�J�����ʒu��߂�
                transform.localPosition = pos;
            }
        }

    }
}
