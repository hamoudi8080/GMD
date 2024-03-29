using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
  //  public Transform characterPlayer;

    NavMeshAgent agent;

    public float attackRaduis =10;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", agent.velocity.magnitude);
        float distance = Vector3.Distance(transform.position, LevelManager.instance.player.position);
        if (distance < attackRaduis)
        {
            agent.SetDestination(LevelManager.instance.player.position);
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player Contacted");
            //Reduce Health
            Destroy(gameObject);
        }
        
    }
}
