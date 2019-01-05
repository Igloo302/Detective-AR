using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamerController : MonoBehaviour
{
    public GameObject ingameSettings;

    public GameObject ingameEvidence;

    public GameObject ingameStory;

    public GameObject ingameAchi;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSettings()
    {
        ingameSettings.SetActive(true);
    }

    public void OnResume()
    {
        ingameSettings.SetActive(false);
    }



    public void OnPublic()
    {
        ingameEvidence.SetActive(false);
    }

    public void OnSteal()
    {
        ingameEvidence.SetActive(false);
    }

    public void OnStory()
    {
        ingameStory.SetActive(true);
    }

    public void OnCloseStory()
    {
        ingameStory.SetActive(false);
    }

    public void OnAchi()
    {
        ingameAchi.SetActive(true);
    }

    public void OnCloseAchi()
    {
        ingameAchi.SetActive(false);
    }
}
