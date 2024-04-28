using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    /*
    public Transform characterPlayer;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Debug.Log("Player Contacted"); 
        Destroy(gameObject);
    }

    */
    
   // public Transform characterPlayer;

    NavMeshAgent agent;

    public float attackRaduis =20f;

    Animator animator;

   public   bool canAttack = true;
    float attackCooldown = 3f;

    CharacterStats stats;

 

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
        stats = GetComponent<CharacterStats>();
    }

    // Update is called once per frame
    void Update()
    {
        // here we set enemy animation to walk. 
        animator.SetFloat("Speed", agent.velocity.magnitude);
        //here we finde the distance between the enemy and player
        float distance = Vector3.Distance(transform.position, LevelManager.instance.player.position);
        //we make a condition if distance is less fx than 5.
        if (distance < attackRaduis)
        {
            //follow the player
            agent.SetDestination(LevelManager.instance.player.position);
            
            //if distance between player and enemy is very very close, the enemy will attack by triggring the attack animation
            if (distance <= agent.stoppingDistance)
            {
                if (canAttack && stats.isAlive)
                {
                    Debug.Log("can attack now " + stats.isAlive);
                    //trigger the attack every fx 3sec
                    StartCoroutine(coolddown());
                    animator.SetTrigger("Attack");
                   // LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[5], LevelManager.instance.player.position);
                    LevelManager.instance.PlaySound(LevelManager.instance.levelSounds[6], LevelManager.instance.player.position);


                }
            }
        }

      

    }
    IEnumerator coolddown()
    {

        
        canAttack = false;
        yield return new WaitForSeconds(attackCooldown);

        // Check if the player is still alive before allowing the enemy to attack again
        if (LevelManager.instance.player != null && LevelManager.instance.player.GetComponent<CharacterStats>().isAlive)
        {
            canAttack = true;
        }
         
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Contacted");

            //we know when two objects collies this method will be triggered.
            //since this script is attached to enemy object so other is the player.
            //other is an object inside Player object, "other is collider component of player"
            //-other.GetComponentInParent<CharacterStats>().power    in this line we get power which is = 10 of the characterStats of player object 
            //so since the enemy has stats of health fx 40, with every time the player hits the enemy it will decrease the health of it with 10
            stats.ChangeHealth(-other.GetComponentInParent<CharacterStats>().power);

          
            //Reduce Health
            // Destroy(gameObject);
        }
        
    }

    //here we call the player and change its health directlly 
    public void DamagePlayer()
    {
        if (stats.isAlive) // Check if the player is alive before damaging
            LevelManager.instance.player.GetComponent<CharacterStats>().ChangeHealth(-stats.power);

    }
    
}
