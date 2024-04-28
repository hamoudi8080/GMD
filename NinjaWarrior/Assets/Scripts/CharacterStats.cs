using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.UI;
public class CharacterStats : MonoBehaviour
{


    [SerializeField]
    float maxHealth = 100;
    public float power = 10;
    int killScore = 200;
    //public float currentHealth { get; private set; }

    public float currentHealth { get;   set; }
    public bool isAlive { get; private set; } = true; // Add this line

    private CanvasTexts canvasTexts { get; set; }



    public GameOverScript GameOverSreen;


    // Start is called before the first frame update



    void Start()
    {
        currentHealth = maxHealth;
        canvasTexts = GameObject.FindObjectOfType<CanvasTexts>(); // Instantiate the CanvasTexts object
    }

    public void ChangeHealth(float value)
    {
        //currentHealth += value;
        currentHealth = Mathf.Clamp(currentHealth + value, 0, maxHealth);

        if (transform.CompareTag("Enemy"))

            transform.Find("Canvas/pfHealthBarUIWorldCanvas/HealthBarUI/Bar").GetComponent<Image>().fillAmount = currentHealth / maxHealth;


        if (transform.CompareTag("Player"))

            transform.Find("Canvas/pfHealthBarUIWorldCanvas/HealthBarUI/Bar").GetComponent<Image>().fillAmount = currentHealth / maxHealth;

        if (currentHealth <= 0)
        {
            isAlive = false;  
            Die();
            
        }

     
        Debug.Log("Current Health" + currentHealth + "/" + maxHealth);
    }

    void Die()
    {
        if (transform.CompareTag("Player"))
        {
            
            // Trigger the die animation
            Animator animator = GetComponentInChildren<Animator>();
            if (animator != null)
            {
                animator.SetTrigger("Die");
                
            }

            StartCoroutine(DelayedGameOverLogic(5f));
            //game over
            /*
            if (canvasTexts != null)
            {
                GameOverSreen.Setup(canvasTexts.kills);
            }
            else
            {
                Debug.LogWarning("CanvasTexts object not found.");
            }
            */
            
        }
        else if (transform.CompareTag("Enemy"))
        {
            LevelManager.instance.score += killScore;
            LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[7], LevelManager.instance.player.position);
            Instantiate(LevelManager.instance.particales[2], transform.position, transform.rotation);

            EnemyManager.EnemyDefeated();

            // Increase kills score in CanvasTexts
            canvasTexts.kills++;

            Destroy(gameObject);

          
        }

    }



    IEnumerator DelayedGameOverLogic(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);

        //game over
        if (canvasTexts != null)
        {
            GameOverSreen.Setup(canvasTexts.kills);
        }
        else
        {
            Debug.LogWarning("CanvasTexts object not found.");
        }
    }



}
