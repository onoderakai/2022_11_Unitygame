using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigid;

    float walkForce = 30.0f;
    float maxWalkForce = 10.0f;
    //string objTag = "";

    int dir = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.3f;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0.0f, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0.0f, 0.0f);
            //transform.Rotate(0.0f, 0.0f, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.0f, 0.0f, -speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0.0f, 0.0f);
            //transform.Rotate(0.0f, 0.0f, -speed);
        }
        
        
        ////プレイヤーの速度
        //float speedX = Mathf.Abs(this.rigid.velocity.x);
        //float speedZ = Mathf.Abs(this.rigid.velocity.z);
        //
        //
        //Vector3 speed;
        //if (!Input.anyKey)
        //{
        //
        //    speed.x = 0.0f;
        //    speed.z = 0.0f;
        //    speed.y = rigid.velocity.y;
        //    this.rigid.velocity = speed;
        //}
        //if (Input.GetKey(KeyCode.W) && speedZ < maxWalkForce)
        //{
        //    dir = 1;
        //    if (!Input.GetKey(KeyCode.A) &&
        //        !Input.GetKey(KeyCode.D))
        //    {
        //        speed.x = 0.0f;
        //        speed.z = rigid.velocity.z;
        //        speed.y = rigid.velocity.y;
        //        this.rigid.velocity = speed;
        //    }
        //    this.rigid.AddForce(transform.forward * dir * this.walkForce);
        //}
        //if (Input.GetKey(KeyCode.A) && speedX < maxWalkForce)
        //{
        //    dir = -1;
        //    if (!Input.GetKey(KeyCode.W) &&
        //        !Input.GetKey(KeyCode.S))
        //    {
        //        speed.x = rigid.velocity.x;
        //        speed.z = 0.0f;
        //        speed.y = rigid.velocity.y;
        //        this.rigid.velocity = speed;
        //        
        //    }
        //    //transform.Rotate(0.0f, 0.0f, dir * this.walkForce);
        //    this.rigid.AddForce(transform.right * dir * this.walkForce);
        //}
        //if (Input.GetKey(KeyCode.S) && speedZ < maxWalkForce)
        //{
        //    dir = -1;
        //    if (!Input.GetKey(KeyCode.A) &&
        //        !Input.GetKey(KeyCode.D))
        //    {
        //        speed.x = 0.0f;
        //        speed.z = rigid.velocity.z;
        //        speed.y = rigid.velocity.y;
        //        this.rigid.velocity = speed;
        //    }
        //    this.rigid.AddForce(transform.forward * dir * this.walkForce);
        //}
        //if (Input.GetKey(KeyCode.D) && speedX < maxWalkForce)
        //{
        //    dir = 1;
        //    if (!Input.GetKey(KeyCode.W) &&
        //        !Input.GetKey(KeyCode.S))
        //    {
        //        speed.x = rigid.velocity.x;
        //        speed.z = 0.0f;
        //        speed.y = rigid.velocity.y;
        //        this.rigid.velocity = speed;
        //       
        //    }
        //    //transform.Rotate(0.0f, 0.0f, dir * this.walkForce);
        //    this.rigid.AddForce(transform.right * dir * this.walkForce);
        //}
    }
}
