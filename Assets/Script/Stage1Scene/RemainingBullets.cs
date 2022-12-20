using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//unityのUI表示に必要

public class RemainingBullets : MonoBehaviour
{
    //スクリプトの取得
    GameObject bulletsGeneratorOb;
    BulletsGenerator bulletsGeneratorSc;

    // Start is called before the first frame update
    void Start()
    {
        //スクリプトの取得
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
