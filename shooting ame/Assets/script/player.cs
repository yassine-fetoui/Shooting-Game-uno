using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player: Singelton<player>
{
    public void Awake()
    {
        base.RegistreSingelton();
    }

    public void SetHealth(int health)
{

}


}
  