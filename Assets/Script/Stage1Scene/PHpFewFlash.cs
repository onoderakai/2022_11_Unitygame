using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PHpFewFlash : MonoBehaviour
{
    Color color;
    HpManager hpManager;
    float flashSpeed = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        hpManager=GameObject.Find("HpManager").GetComponent<HpManager>();

        color = gameObject.GetComponent<Image>().color;
        color.a = 0.0f;
        gameObject.GetComponent<Image>().color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if(hpManager.GetHpCount() <= 4)
        {
            if(hpManager.GetHpCount() <= 2)
            {
                color.a += flashSpeed * (5 - hpManager.GetHpCount()) * 0.5f;
            }
            else
            {
                color.a += flashSpeed * (5 - hpManager.GetHpCount()) * 0.1f;
            }
            
            gameObject.GetComponent<Image>().color = color;
            if(color.a > (5 - hpManager.GetHpCount()) * 0.1f)
            {
                flashSpeed *= -1;
            }
            else if(color.a < 0.0f)
            {
                flashSpeed *= -1;
            }
        }
        if(hpManager.GetHpCount() == 0)
        {
            color.a = 0.2f;
            gameObject.GetComponent<Image>().color = color;
        }
    }
}
