using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject star;

    //public Text score;
    public TextMeshProUGUI score;

    private int playerScore = 0;
    private string playerscoreString;

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
            playerscoreString = Convert.ToString(playerScore);
            score.text = playerscoreString;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}