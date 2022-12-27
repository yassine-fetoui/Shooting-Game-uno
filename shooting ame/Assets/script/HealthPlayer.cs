using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPlayer : MonoBehaviour

{
    private playerMovement player1;
    private float health;
    private const float MAX_HEALTH = 100;
    // Start is called before the first frame update
    private void Awake()
    {
        player1= GetComponent<playerMovement>();
    }


    private void Start()
    {
        health = MAX_HEALTH;

    }

    // Update is called once per frame


    public void DecreaseHealth(int amountOfHealth)
    {
        health -= amountOfHealth;   

        if (player.instance)
        {


            if (health <= 0)
            {
                //player is dead
                
                Destroy(gameObject);
                GameManager.instance.onGameOver();
            }
        }

    }

}   