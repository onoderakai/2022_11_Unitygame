using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;//シーン遷移に必要

public class Transparent : MonoBehaviour
{
    Color color;
    SpaceNext spaceNext;
    // Start is called before the first frame update
    void Start()
    {
        color = gameObject.GetComponent<Image>().color;
        color.a = 1;
        gameObject.GetComponent<Image>().color = color;
        gameObject.SetActive(true);
        spaceNext = GameObject.Find("SceneManager").GetComponent<SpaceNext>();
    }

    // Update is called once per frame
    void Update()
    {
        if (spaceNext.GetEaseFlag() && color.a < 1.0f)
        {
            color.a += 0.05f;
            gameObject.GetComponent<Image>().color = color;
            if (color.a >= 1.0f)
            {
                color.a = 1.0f;
                SceneManager.LoadScene(2);
            }
        }
        else if (color.a > 0)
        {
            color.a -= 0.05f;
            gameObject.GetComponent<Image>().color = color;
        }
        else
        {
            color.a = 0;
        }
        
    }
}
