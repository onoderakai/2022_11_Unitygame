using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIに必要

public class ClearSelect : MonoBehaviour
{
    //テキストを取得
    Text clearSelect;
    int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        clearSelect=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        count++;
        if (count >= 15)
        {
            count = 0;
            if (!clearSelect.enabled)
            {
                clearSelect.enabled = true;
            }
            else
            {
                clearSelect.enabled = false;
            }
        }
    }
}
