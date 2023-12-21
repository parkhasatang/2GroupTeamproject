using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public PlayerHP playerHP;
    public PlayerGold playerGold;
    public GameObject endPannel;
    public GameObject ClearPannel;
    public float GameTime;
    public TMP_Text TimeText;
    public EnemySpawner enemySpawner;

    public static UIManager instance;

    public event Action stageClearAction;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        StageStart();
    }

    private void Update()
    {
        TimeDown();
    }

    private void TimeDown()
    {
        if (GameTime > 0)
        {
            GameTime -= Time.deltaTime;
            if(GameTime < 0) // Á» ²ÜÆÁ, ¹ß»óÀÇ ÀüÈ¯
            {
                enemySpawner.SpawnBoss();
                GameTime = 0;
            }
        }
        TimeText.text = GameTime.ToString("N2");
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        endPannel.SetActive(true);
    }

    public void StageClear()
    {
        Time.timeScale = 0;
        ClearPannel.SetActive(true);
    }

    public void NextStage()
    {
        SceneManager.LoadScene("MapScene");
    }

    public void IntroScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void StageStart()
    {
        Time.timeScale = 1;
        endPannel.SetActive(false);
        ClearPannel.SetActive(false);
        stageClearAction?.Invoke();
    }

    public void RetryScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
