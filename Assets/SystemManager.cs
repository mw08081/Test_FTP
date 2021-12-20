using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemManager : MonoBehaviour
{
    static SystemManager instance;
    public static SystemManager Instance
    {
        get
        {
            return instance;
        }
    }

    [SerializeField] GameObject[] playerPrefabs;

    [SerializeField] Player player1;
    public Player Player1
    {
        get
        {
            return player1;
        }
    }
    [SerializeField] Player player2;
    public Player Player2
    {
        get
        {
            return player2;
        }
    }

    bool isGeneP1;
    bool isGeneP2;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
            isGeneP1 = true;

        if (Input.GetKeyDown(KeyCode.A))
            isGeneP2 = true;

        if(isGeneP1)
        {
            GenePlayer1();
        }

        if(isGeneP2)
        {
            GenePlayer2();   
        }

    }

    void GenePlayer1()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GeneP1(0);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            GeneP1(1);
        }
        else if(Input.GetKeyDown(KeyCode.C))
        {
            GeneP1(2);
        }
    }

    void GenePlayer2()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GeneP2(0);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            GeneP2(1);
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            GeneP2(2);
        }
    }

    void GeneP1(int i)
    {
        GameObject p1 = Instantiate(playerPrefabs[i]);
        p1.transform.position = transform.position;
        
        player1 = p1.GetComponent<Player>();
        p1.AddComponent<P1Controller>();

        isGeneP1 = false;
    }

    void GeneP2(int i)
    {
        GameObject p2 = Instantiate(playerPrefabs[i]);
        p2.transform.position = transform.position;
        
        player2 = p2.GetComponent<Player>();
        p2.AddComponent<P2Controller>();

        isGeneP2 = false;
    }
}
