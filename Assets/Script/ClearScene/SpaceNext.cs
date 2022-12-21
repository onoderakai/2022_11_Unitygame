using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//�V�[���J�ڂɕK�v

public class SpaceNext : MonoBehaviour
{
    [SerializeField]
    private bool easeFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            easeFlag = true;
        }
    }
    public bool GetEaseFlag()
    {
        return easeFlag;
    }
}
