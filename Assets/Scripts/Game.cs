using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Game : MonoBehaviour
{
    [Header("Ball")]
    public GameObject ball;

    [Header("Player 1")]
    public GameObject player1;
    public GameObject player1Goal;

    [Header("Player 2")]
    public GameObject player2;
    public GameObject player2Goal;

    [Header("Score UI")]
    public GameObject Player1Points;
    public GameObject Player2Points;

    private int Player1Score;
    private int Player2Score;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Points.GetComponent<TMPro.TextMeshProUGUI>().text = Player1Score.ToString();
        restartPos();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Points.GetComponent<TMPro.TextMeshProUGUI>().text = Player2Score.ToString();
        restartPos();
    }

    private void restartPos()
    {
        ball.GetComponent<Ball>().Reset();
        player1.GetComponent<PlayerMovement>().Reset();
        player2.GetComponent<PlayerMovement>().Reset();
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
