using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpManager : MonoBehaviour
{
    [SerializeField]
    const int maxHp = 5;
    [SerializeField]
    GameObject[] hpObj=new GameObject[maxHp];
    private int hpCount = maxHp;

    // Start is called before the first frame update
    void Start()
    {
        hpCount = maxHp;
    }

    // Update is called once per frame
    void Update()
    {
        if (hpCount >= 0)
        {
            for (int i = 0; i < maxHp - hpCount; i++)
            {
                hpObj[i].SetActive(false);
            }
        }
    }
    //HPのゲッター
    public int GetHpCount()
    {
        return hpCount;
    }
    //HPのセッター
    public void SetHpCount(int hp)
    {
        hpCount = hp;
    }
}
