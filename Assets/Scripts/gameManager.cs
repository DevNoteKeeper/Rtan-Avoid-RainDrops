using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject rain;
    public GameObject panel;

    public static gameManager I;

    public Text scoreText;
    int totalScore = 0;
    float limit = 30.0f;
    public Text timeText;


    void Awake() {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0f, 0.5f);
        initGame();
    }

    void initGame(){
        Time.timeScale = 1.0f;
        totalScore = 0;
        limit = 30.0f;
    }

    void makeRain(){
        Instantiate(rain);
    }

    public void addScore(int Score){
        totalScore+= Score;
        scoreText.text = totalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        limit -= Time.deltaTime;
        if(limit < 0 || totalScore < 0){
            Time.timeScale = 0.0f;
            limit = 0.0f;

            panel.SetActive(true);
        }
        timeText.text = limit.ToString("N2");
    }
    public void retry(){
        SceneManager.LoadScene("MainScene");
    }
}
