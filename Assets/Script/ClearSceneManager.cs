using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���J�ڂɕK�v

public class ClearSceneManager : MonoBehaviour
{
    //���֘A
    public AudioClip clearSe;
    AudioSource clearSource;
    bool isClear = false;

    // Start is called before the first frame update
    void Start()
    {
        clearSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isClear)
        {
            isClear = true;
            clearSource.PlayOneShot(clearSe);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScene");
        }
    }
}
