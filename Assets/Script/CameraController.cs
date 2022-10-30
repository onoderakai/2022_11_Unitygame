using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    Vector2 vibration = Vector2.zero;
    Vector2 maxVibration;
    Vector2 vibrationRange = Vector2.zero;
    bool flag = false;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        maxVibration.x = 1.0f;
        maxVibration.y = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(playerPos.x + vibration.x, playerPos.y + 20.0f + vibration.y, playerPos.z - 8.0f);
        if (Input.GetKeyDown(KeyCode.Return) && !flag)
        {
            flag = true;
            vibrationRange = maxVibration;
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            flag = false;
        }
        if (flag)
        {
            vibration.x = Random.Range(-vibrationRange.x, vibrationRange.x);
            vibration.y = Random.Range(-vibrationRange.y, vibrationRange.y);
            if (vibrationRange.x > 0)
            {
                vibrationRange.x -= 0.1f;
            }
            if (vibrationRange.y > 0)
            {
                vibrationRange.y -= 0.1f;
            }
        }
    }
}
