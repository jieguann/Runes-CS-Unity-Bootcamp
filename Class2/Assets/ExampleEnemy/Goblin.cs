using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Enemy
{
    
    override protected void Attack()
    {

    }

    public void Flee()
    {
        Attack();
    }

    protected override void Taunt()
    {
        base.Taunt();
        m_health += 10;
    }
}
