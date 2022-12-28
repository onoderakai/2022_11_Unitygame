using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    int time = 0;
    int destroyTime = 600;
    //コンポーネントの取得
    [SerializeField] AudioClip defeatSe;
    [SerializeField] AudioClip bulletHitSource;
    AudioSource defeatSource;
    bool isSe = false;
    int soundType = 0;

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
            if(soundType == 0)
            {
                //SEを鳴らす
                defeatSource.PlayOneShot(defeatSe);
            }
            else if(soundType == 1)
            {
                //SEを鳴らす
                defeatSource.PlayOneShot(bulletHitSource);
            }
        }
        time++;
        if (time > destroyTime)
        {
            Destroy(gameObject);
        }
    }
    public void SetSoundType(int soundType)
    {
        this.soundType = soundType;
    }
}
