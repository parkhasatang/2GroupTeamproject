using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class UIManager : MonoBehaviour
{
    public PlayerHP playerHP;
    public PlayerGold playerGold;
    public GameObject endPannel;
    public static UIManager instance;

    public event Action stageClearAction;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        StageClear();
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        endPannel.SetActive(true);
    }

    public void StageClear()
    {
        Time.timeScale = 1;
        endPannel.SetActive(false);
        stageClearAction?.Invoke();
    }

    public void IntroScene()
    {
        SceneManager.LoadScene("StartDeokScene");
    }
}
