using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singelton<GameManager>
{
    public void onGameOver()
    {
        Debug.Log("game over");
    }
    // Start is called before the first frame update

   
}
