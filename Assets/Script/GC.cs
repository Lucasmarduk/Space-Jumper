using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GC : MonoBehaviour
{
    private bool isGameRunning;
    public Gerador gerador;
    private int score;
    public TextMeshProUGUI scoreLabel;
    // Start is called before the first frame update
    void Start()
    {
        isGameRunning = false;
        GameStart();
    }

    private void Update()
    {
        scoreLabel.text = score.ToString();
        if (!isGameRunning) return;
        score++;
    }
    void GameStart() 
    {
       isGameRunning = true;
        gerador.GerarObstaculos();
        score = 0;
    }

    public void GameOver() 
    {
        print("Fim de jogo");
       isGameRunning = false;
        gerador.PararGerador();
    }
}
