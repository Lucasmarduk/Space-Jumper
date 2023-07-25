using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GC : MonoBehaviour
{
    private bool isGameRunning;
    public Gerador gerador;
    private int score;
    public TextMeshProUGUI scoreLabel;
    private static GC instance;
    public GameObject TelaGameOver;
    public GameObject BG;
    public GameObject Gerador;
    public GameObject ground;
    public GameObject GameManager;
    public static GC Instance => instance;
    private bool gameOver;
    
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        isGameRunning = true;
        gerador.GerarObstaculos();
        score = 0;

    }

    private void Update()
    {
        scoreLabel.text = score.ToString();
        if (!isGameRunning) return;
        score++;
        if(gameOver) 
            return; 
    }
    

    public void GameOver()
    {
        gameOver = true;
        print("Fim de jogo");
        isGameRunning = false;
        gerador.PararGerador();
        TelaGameOver.SetActive(true);
        BG.SetActive(false);
        Gerador.SetActive(false);
        ground.SetActive(false);
        GameManager.SetActive(false);
    }
    
}
