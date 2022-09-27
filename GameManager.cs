using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject star;

    public Text score;

    private int playerScore = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == star.tag)
        {
            collision.gameObject.SetActive(false);
            playerScore = playerScore + 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Convert.ToString(playerScore);
    }
}