using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    string objTag = "";
    //prefab‚ÌŽæ“¾
    public GameObject particlePrefab;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 0.5f;
        transform.Translate(0.0f, 0.0f, speed);

        //“–‚½‚è”»’è
        if(objTag == "enemy")
        {
            GameObject particle = Instantiate(particlePrefab) as GameObject;
            particle.transform.position = transform.position;

            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        objTag=other.gameObject.tag;
    }
}
