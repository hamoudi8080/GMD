using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePlayerHealth : MonoBehaviour
{

    private CanvasTexts canvasTexts { get; set; }

    private void Start()
    {
        canvasTexts = GameObject.FindObjectOfType<CanvasTexts>(); // Instantiate the CanvasTexts object
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Health"))
        {
            Debug.Log("Health Increased!");

            GetComponent<CharacterStats>().ChangeHealth(20);
            LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[1], LevelManager.instance.player.position);

            Instantiate(LevelManager.instance.particales[1], other.transform.position, other.transform.rotation);

            canvasTexts.hearts++;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Item"))
        {
            LevelManager.instance.levelItems++;
           // LevelManager.instance.scoreText = LevelManager.instance.levelItems++.ToString;
            Debug.Log("Items : " + LevelManager.instance.levelItems);
            LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[2], LevelManager.instance.player.position);
            Instantiate(LevelManager.instance.particales[0], other.transform.position, other.transform.rotation);

            //increase itemscore everytime 
            canvasTexts.items++;

            Destroy(other.gameObject);
        }
    }

}
