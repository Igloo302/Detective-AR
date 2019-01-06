using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadingDone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReallyStart()
    {
        SceneManager.LoadScene("UnityARKitScene");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Home");
    }
}
