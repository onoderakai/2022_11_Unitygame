using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsGenerator : MonoBehaviour
{
    //ゲームオブジェクトを取得
    GameObject player;
    public GameObject bulletPrefab;

    int bulletsCoolTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && bulletsCoolTime <= 0)
        {
            bulletsCoolTime = 30;
            Vector3 pos = player.transform.position;

            GameObject Shot = Instantiate(bulletPrefab) as GameObject;
            Shot.transform.position = new Vector3(pos.x - 0.15f, pos.y + 13.27f, pos.z + 4.0f);
        }
        if(bulletsCoolTime > 0)
        {
            bulletsCoolTime--;
        }
    }
}
