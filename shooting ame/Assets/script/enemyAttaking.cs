using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttaking : MonoBehaviour
{   private Animator animator;
    private bool AttackingActive=false;
    private HealthPlayer playerHealth; 
    private void Awake()
    {
        animator=GetComponent<Animator>(); 
        playerHealth= FindObjectOfType<HealthPlayer>();  
    }
    public virtual void Attack()
     
        {  
           if (AttackingActive == true)
                  return; 
        
           AttackingActive=true;

        StartCoroutine(routine());
           
         }

    public virtual void stoppAttack()
    {
        AttackingActive=false;  
    }
   private IEnumerator routine()
    {
        animator.SetBool("Attack", true);
        
        while (AttackingActive == true)
        {
            playerHealth.DecreaseHealth(5);
            yield return (new WaitForSeconds(2));

        }
        yield return null;
    }
  
}
