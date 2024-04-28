using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeNextLevelCanvas : MonoBehaviour
{
    public bool startGame;

    public static WelcomeNextLevelCanvas ins;


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
            OkButton();
        }
    }

    public void OkButton()
    {
        SceneManager.LoadScene("CityScene");
    }


    public void OtherOkButton()
    {
        Debug.Log("clicked");
        SceneManager.LoadScene("CityScene");
    }
}
