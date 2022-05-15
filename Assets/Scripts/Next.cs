using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    private UIManager UImanage;
    // Start is called before the first frame update
    void Start()
    {
        UImanage = GameObject.Find("Managers").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.gameObject.CompareTag("Next"))
        {
            Debug.Log(SceneManager.GetActiveScene().buildIndex);
            
            if (SceneManager.GetActiveScene().buildIndex == 1)
            {
                UImanage.LoadLevelTwo();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 2)
            {
                UImanage.LoadLevelThree();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 3)
            {
                UImanage.LoadLevelFour();
            }
            else if (SceneManager.GetActiveScene().buildIndex == 4)
            {
                UImanage.LoadStart();
            }
        }
    }
}
