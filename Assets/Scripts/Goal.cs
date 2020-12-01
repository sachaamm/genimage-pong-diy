﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (!isPlayer1Goal)
            {
                Debug.Log("Player 2 Scored !");
                GameObject.Find("Game").GetComponent<Game>().Player1Scored();
            } else
            {
                Debug.Log("Player 1 Scored !");
                GameObject.Find("Game").GetComponent<Game>().Player2Scored();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
