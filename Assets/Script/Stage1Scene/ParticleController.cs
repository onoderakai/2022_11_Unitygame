using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    int time = 0;
    int destroyTime = 600;
    //�R���|�[�l���g�̎擾
    public AudioClip defeatSe;
    AudioSource defeatSource;
    bool isSe = false;

    // Start is called before the first frame update
    void Start()
    {
        //�R���|�[�l���g�̎擾
        defeatSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isSe)
        {
            isSe = true;
            //SE��炷
            defeatSource.PlayOneShot(defeatSe);
        }
        time++;
        if (time > destroyTime)
        {
            Destroy(gameObject);
        }
    }
}
