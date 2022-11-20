using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    string objTag = "";
    //�Q�[���I�u�W�F�N�g���擾
    GameObject player;
    //�ړ����x
    Vector3 move= Vector3.zero;
    int count = 0;
    float speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //�Q�[���I�u�W�F�N�g���擾
        player = GameObject.Find("playerEmpty");
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion lookObj = Quaternion.LookRotation((player.transform.position - transform.position) * -1, Vector3.up);
        lookObj.x = 0.0f;
        lookObj.z = 0.0f;
        transform.rotation = Quaternion.Lerp(transform.rotation, lookObj, 0.1f);
        count++;
        if (count >= 60)
        {
            count = 0;
            speed=Random.Range(-0.3f, 0.3f);
            
        }
        
        move.x = speed;
        //move.z = Random.Range(-speed, speed);
        Debug.Log(speed);
        transform.Translate(move);

        if(objTag == "bullet")
        {
            Destroy(gameObject);
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        objTag = other.gameObject.tag;
    }
}
