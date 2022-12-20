using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI‚É•K—v

public class SceneChangeSc : MonoBehaviour
{
    GameObject sceneChangeBg;
    //
    [SerializeField] private bool easeFlag = false;
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
        if (easeFlag)
        {
            color.a += 0.01f;
            gameObject.GetComponent<Image>().color = color;
            Debug.Log(color.a);
        }
        
    }

    public void SetEaseFlag(bool flag)
    {
        easeFlag = flag;
    }
}
