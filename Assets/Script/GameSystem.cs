using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーン遷移に必要

public class GameSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //ボタンを押したらシーン遷移
    public void StartGame()
    {
        SceneManager.LoadScene("ExplainScene");
    }
}
