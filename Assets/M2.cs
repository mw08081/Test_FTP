using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M2 : Player
{
    protected override void Attack()
    {
        base.Attack();
        Debug.Log("m2 attack");
    }
}
