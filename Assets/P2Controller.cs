using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Controller : MonoBehaviour
{
    Player myPlayer;
    float speed;

    void Start()
    {
        myPlayer = GetComponent<Player>();
        speed = myPlayer.speed;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMove();
        UpdateAttack();
    }

    void UpdateMove()
    {
        //Vector3 movedir = Vector3.zero;
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        //    movedir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //transform.position += movedir * 10 * Time.deltaTime;

        Vector3 movedir = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
            movedir.z = 1.0f;
        else if (Input.GetKey(KeyCode.S))
            movedir.z = -1.0f;
        else
            movedir.z = 0.0f;

        if (Input.GetKey(KeyCode.A))
            movedir.x = -1.0f;
        else if (Input.GetKey(KeyCode.D))
            movedir.x = 1.0f;
        else
            movedir.x = 0.0f;

        movedir = movedir.normalized;

        transform.position += movedir * speed * Time.deltaTime;
    }

    void UpdateAttack()
    {
        if (Input.GetKeyDown(KeyCode.F))
            myPlayer.CallAttackFunc();
    }
}
