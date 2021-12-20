using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] public float speed;

    protected bool isp1;

    void Start()
    {
        isp1 = true;
    }

    void Update()
    {
        
    }

    public void CallAttackFunc()
    {
        Attack();
    }
    protected virtual void Attack()
    {
        Debug.Log("attack!! - Player");
    }

    public void SettingPlayerInfo(bool _isp1)
    {
        isp1 = _isp1;
    }
}
