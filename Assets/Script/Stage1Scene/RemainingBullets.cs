using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//unity��UI�\���ɕK�v

public class RemainingBullets : MonoBehaviour
{
    //�X�N���v�g�̎擾
    GameObject bulletsGeneratorOb;
    BulletsGenerator bulletsGeneratorSc;

    // Start is called before the first frame update
    void Start()
    {
        //�X�N���v�g�̎擾
        bulletsGeneratorOb = GameObject.Find("BulletsGenerator");
        bulletsGeneratorSc = bulletsGeneratorOb.GetComponent<BulletsGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        Text remainingBulltes=GetComponent<Text>();
        remainingBulltes.text = "x  " + bulletsGeneratorSc.remainingBullets;
    }
}
