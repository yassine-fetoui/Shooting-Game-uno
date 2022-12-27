using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletDestroy : MonoBehaviour
{
    public string targetshooting;
    public targetToDestroy target; 
    public enum targetToDestroy  {Enemy , player };



    private void OnTriggerEnter(Collider colider)
    {
      if (colider.gameObject.tag == targetshooting)
        {
            if (targetToDestroy.player == target)
            {
                if (colider.gameObject)
                colider.gameObject.GetComponent<HealthPlayer>().DecreaseHealth(10) ;

                    
            }
            if (targetToDestroy.Enemy == target)
            {
                Destroy(colider.gameObject);

            }
          
        }
        Destroy(gameObject);
    }
}