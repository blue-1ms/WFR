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
            }
        }
        
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
            IntroText = FindObjectOfType<TextMeshProUGUI>();
            IntroText.text = "Helloooooo";
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2 || SceneManager.GetActiveScene().buildIndex == 3)
        {
            Cursor.visible = false;
        }
    }
}
