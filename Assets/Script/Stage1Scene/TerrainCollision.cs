using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainCollision : MonoBehaviour
{
    string objTag;
    Vector3 hitPos;
    bool initializeFlag = false;

    //ƒvƒŒƒnƒu‚ÌŽæ“¾
    [SerializeField] GameObject terrainHitFireParticle;
    [SerializeField] GameObject terrainHitParticle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(objTag != null && initializeFlag)
        {
            initializeFlag = false;
            GameObject terrainFireParticle = Instantiate(terrainHitFireParticle) as GameObject;
            GameObject terrainParticle = Instantiate(terrainHitParticle) as GameObject;
            terrainFireParticle.transform.position = hitPos;
            terrainParticle.transform.position = hitPos;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        objTag=other.gameObject.tag;
        hitPos = other.ClosestPointOnBounds(this.transform.position);
        initializeFlag = true;
    }
}
