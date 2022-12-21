using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���J�ڂɕK�v

public class GameSystem : MonoBehaviour
{

    //�C�[�W���O�t���O
    [SerializeField] private bool easeFlag = false;
    //�Q�[���I�u�W�F�N�g���擾
    [SerializeField]
    GameObject sceneChangeObj;
    //�X�N���v�g���擾
    SceneChangeSc sceneChangeSc;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
        this.sceneChangeObj = GameObject.Find("EaseBg");
        sceneChangeObj.SetActive(false);
        sceneChangeSc = sceneChangeObj.GetComponent<SceneChangeSc>();
    }

    // Update is called once per frame
    void Update()
    {
        if (easeFlag)
        {
            GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
        }
        if (sceneChangeSc.GetEaseComplete())
        {
            sceneChangeSc.SetEaseComplete(false);
            SceneManager.LoadScene(1);
            
        }
    }

    //�{�^������������V�[���J��
    public void StartGame()
    {
        easeFlag = true;
        sceneChangeObj.SetActive(true);
    }


}
