using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsGenerator : MonoBehaviour
{
    int bulletsCoolTime = 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && bulletsCoolTime <= 0)
        {
            bulletsCoolTime = 30;

        }
        if(bulletsCoolTime > 0)
        {
            bulletsCoolTime--;
        }
    }
}
