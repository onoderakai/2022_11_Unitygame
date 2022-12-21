using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitTime : MonoBehaviour
{
    int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time++;
        if(time > 600)
        {
            time = 0;
            Destroy(gameObject);
        }
    }
}
