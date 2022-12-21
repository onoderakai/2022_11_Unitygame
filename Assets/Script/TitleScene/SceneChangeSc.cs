using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI‚É•K—v

public class SceneChangeSc : MonoBehaviour
{
    GameObject sceneChangeBg;
    //
    [SerializeField] bool easeFlag = false;
    bool easeComplete = false;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        this.sceneChangeBg = GameObject.Find("EaseBg");
        color = gameObject.GetComponent<Image>().color;
        color.a = 0;
        gameObject.GetComponent<Image>().color = color;
    }

    // Update is called once per frame
    void Update()
    {
        if (easeFlag && !easeComplete)
        {
            color.a += 0.05f;
            gameObject.GetComponent<Image>().color = color;
            if (color.a > 1)
            {
                color.a = 1;
                easeComplete = true;
            }
        }
        else if (easeFlag && easeComplete)
        {
            color.a -= 0.01f;
            gameObject.GetComponent<Image>().color = color;
            if (color.a <= 0)
            {
                color.a = 0;
                easeComplete = false;
                easeFlag = false;

            }
        }

    }

    public void SetEaseFlag(bool flag)
    {
        easeFlag = flag;
    }
    public void SetEaseComplete(bool flag)
    {
        easeComplete = flag;
    }
    public bool GetEaseComplete()
    {
        return easeComplete;
    }
}
