using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSceneScript  : MonoBehaviour
{
    public bool startGame;

    public static MainMenuSceneScript ins;


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        ins = this;
    }

    private void Update()
    {
        // Check for ESC key press to show main menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowMainMenu();
        }
    }



    public void OnstartButton()
    {
        startGame = true;
        SceneManager.LoadScene("MainScene");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    // Method to show the main menu
    public void ShowMainMenu()
    {
        SceneManager.LoadScene("MainMenuScene"); // Replace "MainMenu" with the name of your main menu scene
    }



    public void OkButton()
    {
        SceneManager.LoadScene("CityScene");  
    }


}
