using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI IntroText;
    public TextMeshProUGUI CountUp;
    private bool countFlag = false;
    public GameObject canvas;
    private int seconds = 0;

    private float timer = 0.0f;
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            timer += Time.deltaTime;

            if (timer > 1 && timer <= 5)
            {
                IntroText.text = "You are a humanoid robot man who has crash landed on this planet.";
            }
            else if (timer > 5 && timer <= 10)
            {
                IntroText.text = "Your legs have mal-functioned... and you can only run.";
            }
            else if (timer > 10 && timer <= 15)
            {
                IntroText.text = "You need to escape. Your power source is running low.";
            }
            else if (timer > 15 && timer <= 20)
            {
                IntroText.text = "Hurry!";
            }
            else if (timer > 21 && timer < 22)
            {
                IntroText.text = "";
                Destroy(GameObject.Find("IntroBlock1"));
                countFlag = true;
            }

            if (countFlag)
            {
                seconds = (int) (timer - 21f);
                CountUp.text =  seconds.ToString();
            }
        }
        
    }

    public void LoadStart()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    public void LoadLevelTwo()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    public void LoadLevelThree()
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    public void LoadLevelFour()
    {
        SceneManager.LoadScene(4, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    public void LoadMenu()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
    
    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            Cursor.visible = false;
            canvas = GameObject.Find("Canvas");
            IntroText = canvas.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            CountUp = canvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3 || SceneManager.GetActiveScene().buildIndex == 4)
        {
            Cursor.visible = false;
        }
    }

}
