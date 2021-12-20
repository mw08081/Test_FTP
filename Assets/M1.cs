using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1 : Player
{
    protected override void Attack()
    {
        base.Attack();
        Debug.Log("m1 attack");
    }
}
