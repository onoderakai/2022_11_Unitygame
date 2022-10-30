using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.3f;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, speed, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0.0f, 0.0f);
            transform.Rotate(0.0f, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, -speed, 0.0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0.0f, 0.0f);
            transform.Rotate(0.0f, 0.0f, -speed);
        }
    }
}
