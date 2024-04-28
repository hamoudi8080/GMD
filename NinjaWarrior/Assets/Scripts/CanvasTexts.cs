using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CanvasTexts : MonoBehaviour
{
    // Start is called before the first frame update
    public int items;
    public TextMeshProUGUI itemsText;


    public string gameOver = "";


    public int hearts;
    public TextMeshProUGUI heartsText;


    public int kills = 0;
    public TextMeshProUGUI killsText;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        killsText.text = "kills: " + kills.ToString();
        heartsText.text = "Hearts: " + hearts.ToString();
        itemsText.text = "Items: " + items.ToString();
    }


    /*


    public void EnemyDefeated()
    {
        
        
        if (kills == 2)
        {
            Debug.Log("kills are: " + kills);

            LoadNextScene();
        }



    }

    public void LoadNextScene()
    {
         



        SceneManager.LoadScene("CityScene");
    }
    */
}
