using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ballLocation;

    private GameManager gm;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        if(transform.position.y + 11.5 >= ballLocation.position.y)
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
    }
}
