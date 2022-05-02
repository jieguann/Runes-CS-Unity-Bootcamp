using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy
{
    override protected void Attack()
    {
        
    }

    public void Chase()
    {
        Attack();
    }

    protected override void Taunt()
    {
        //base.Taunt();
        //Climb a hill and yell
        //completely override the function
    }
}
