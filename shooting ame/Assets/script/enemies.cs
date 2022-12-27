using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemies : MonoBehaviour
{
    public  float maxSpeed = 5f;
    public  float currentSpeed ;
    public float stoppingDistance = 5f;
    private bool StartMove=false;
    private player player;
    private enemyAttaking enemyAttaking;
    private NavMeshAgent agent;
    private Animator animator;
    // Start is called before the first frame update
    private void Awake()
    {
        //player = FindObjectOfType<playerMovement>(); // takel barch ressourse mel processeur
        player = player.instance;
       //    player.SetHealth()
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        enemyAttaking = GetComponent<enemyAttaking>();



    }
    private IEnumerator Start()
    {
        yield return ( new WaitForSeconds(3));
        StartMove = true;
    }



 
    // Update is called once per frame
   private  void Update()
    { if (!StartMove)
            return;
    if(player)
     Move();
        
    }
    public virtual void Move()
    {
        if(Vector3.Distance(transform.position,player.transform.position) >= stoppingDistance)
        {
            agent.SetDestination(player.transform.position);
            animator.SetFloat("move",currentSpeed/maxSpeed);
            currentSpeed += Time.deltaTime;
            currentSpeed = Mathf.Clamp(currentSpeed, 0, 5);
            animator.SetBool("Attack", false);
            enemyAttaking.stoppAttack();
        }
        else
        {   
            agent.SetDestination(transform.position);
            currentSpeed = 0;
            animator.SetFloat("move", 0);
            enemyAttaking.Attack();
            Vector3 enemyToPlayer = player.transform.position - transform.position;
            enemyToPlayer.y = 0;
            transform.rotation = Quaternion.LookRotation(enemyToPlayer);
           
        }
    }
    
}
