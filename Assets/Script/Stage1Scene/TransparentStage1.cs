using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransparentStage1 : MonoBehaviour
{
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        color = gameObject.GetComponent<Image>().color;
        color.a = 1;
        gameObject.GetComponent<Image>().color = color;
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(color.a > 0.0f)
        {
            color.a -= 0.01f;
            gameObject.GetComponent<Image>().color = color;
        }
        else
        {
            color.a = 0.0f;
            gameObject.GetComponent<Image>().color = color;
        }
    }
}
