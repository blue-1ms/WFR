using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
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
            /*Button exit = GameObject.FindGameObjectWithTag("ExitButton").GetComponent<Button>();
            exit.onClick.AddListener(LoadMenu); */
            Cursor.visible = false;
        }
        
    }
}
