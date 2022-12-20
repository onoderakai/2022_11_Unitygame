using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���J�ڂɕK�v

public class GameSystem : MonoBehaviour
{

    //�C�[�W���O�t���O
    [SerializeField] private bool easeFlag=false;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
    }

    // Update is called once per frame
    void Update()
    {
        if (easeFlag)
        {
            GameObject.Find("EaseBg").GetComponent<SceneChangeSc>().SetEaseFlag(easeFlag);
        }
    }
    
    //�{�^������������V�[���J��
    public void StartGame()
    {
        easeFlag = true;

        //SceneManager.LoadScene("ExplainScene");
    }
    
    
}
