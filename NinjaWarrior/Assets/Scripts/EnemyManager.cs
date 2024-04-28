using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public static int enemyCount = 5;
    public CanvasTexts canvasTexts; // Assuming CanvasTexts is a MonoBehaviour

    private static EnemyManager instance;

    void Start()
    {
        // Count the number of enemies in the scene
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        canvasTexts = FindObjectOfType<CanvasTexts>(); // Instantiate the CanvasTexts object

        // Set the instance to this object
        instance = this;
    }

    public static void EnemyDefeated()
    {
        // Decrement enemy count when an enemy is defeated
        enemyCount--;

        if (enemyCount == 0)
        {
            // Start a coroutine to wait for 5 seconds before loading the next scene
            instance.StartCoroutine(LoadNextSceneAfterDelay());
        }

        Debug.Log("Enemies left: " + enemyCount);
    }

    private static IEnumerator LoadNextSceneAfterDelay()
    {
        yield return new WaitForSeconds(5f); // Wait for 5 seconds
        LoadNextScene();
    }

    private static void LoadNextScene()
    {
        // Replace "WelcomeToNextLevelScene" with the name of your next scene
        SceneManager.LoadScene("WelcomeToNextLevelScene");
    }

    /*
  
    public static int enemyCount = 5;
    public CanvasTexts canvasTexts { get; set; }


    void Start()
    {
        // Count the number of enemies in the scene
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;

        canvasTexts = GameObject.FindObjectOfType<CanvasTexts>(); // Instantiate the CanvasTexts object
    }

    public static void EnemyDefeated()
    {
        // Decrement enemy count when an enemy is defeated
        
        enemyCount--;

        if (enemyCount == 0)
        {
            LoadNextScene();
        }

        Debug.Log("Enemy left" + enemyCount );

        // Check if all enemies are defeated
         
    }

    public static void LoadNextScene()
    {
        // Replace "NextSceneName" with the name of your next scene


        SceneManager.LoadScene("WelcomeToNextLevelScene");

        //SceneManager.LoadScene("NextSceneName");
    }
     */
}
