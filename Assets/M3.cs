using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M3 : Player
{
    protected override void Attack()
    {
        base.Attack();
        Debug.Log("m3 attack");
    }
}
