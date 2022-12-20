using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    int time = 0;
    int destroyTime = 600;
    //コンポーネントの取得
    public AudioClip defeatSe;
    AudioSource defeatSource;
    bool isSe = false;

    // Start is called before the first frame update
    void Start()
    {
        //コンポーネントの取得
        defeatSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSe)
        {
            isSe = true;
            //SEを鳴らす
            defeatSource.PlayOneShot(defeatSe);
        }
        time++;
        if (time > destroyTime)
        {
            Destroy(gameObject);
        }
    }
}
