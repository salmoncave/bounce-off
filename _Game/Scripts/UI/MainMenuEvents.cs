using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuEvents : MonoBehaviour
{
    [SerializeField] private string _gameLevelName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnAnyButtonPressed(ClickEvent evt)
    {
        //Play Sound Here
    }

    private void OnPlayButtonPressed(ClickEvent evt)
    {
        SceneManager.LoadScene(_gameLevelName);
    }

    private void OnQuitButtonPressed(ClickEvent evt)
    {
        Application.Quit();
    }
}
