using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�ɕK�v

public class ClearSelect : MonoBehaviour
{
    //�e�L�X�g���擾
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
