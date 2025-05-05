using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public TMP_Text scoreText;

    private int score;
    private float timer;
    private float scrollSpeed;
    public float initialScrollSpeed;
    public float finalScrollSpeed;

    public static GameManager Instance {get; private set;}

    private void Awake()
    {
        if(Instance !=null && Instance !=this)
        {
            Destroy(this);
        }
        else
        {
            Instance=this;
        }
    }

    private void Update()
    {
        UpdateScore();
        UpdateSpeed();
    }

    public void ShowGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }

    public void RestarScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    private void UpdateScore()
    {
        int scorePerSeconds = 10;
        timer+=Time.deltaTime;
        score = (int)(timer*scorePerSeconds);
        scoreText.text = string.Format("{0:00000}",score);

    }

    public float GetScrollSpeed()
    {
        return scrollSpeed;
    }

    private void UpdateSpeed()
    {
        float speedDivider = 10f;
        scrollSpeed = initialScrollSpeed + timer / speedDivider;

    }


}
