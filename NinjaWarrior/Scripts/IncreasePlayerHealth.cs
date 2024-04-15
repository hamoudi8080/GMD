using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncreasePlayerHealth : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Health"))
        {
            Debug.Log("Health Increased!");

            GetComponent<CharacterStats>().ChangeHealth(20);
            LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[1], LevelManager.instance.player.position);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Item"))
        {
            LevelManager.instance.levelItems++;
            Debug.Log("Items : " + LevelManager.instance.levelItems);
            LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[2], LevelManager.instance.player.position);
            Destroy(other.gameObject);
        }
    }

}
