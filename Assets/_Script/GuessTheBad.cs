using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuessTheBad : MonoBehaviour
{

    public GameObject inGameWin;

    public GameObject inGameLose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnWin()
    {
        inGameWin.SetActive(true);
    }

    public void OnLose()
    {
        inGameLose.SetActive(true);
    }

    public void OnCloseLose()
    {
        inGameLose.SetActive(false);
    }

    public void GoBackToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
