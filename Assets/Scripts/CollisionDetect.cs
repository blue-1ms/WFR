using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    private UIManager _userInterface;
    private float timer = 0;
    private float timeout = 0;
    private bool flag = false;
    private bool flag1 = false;
    private GameObject manager;
    
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Managers");
        _userInterface = manager.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (flag)
        {
            timeout = timer + 5;
            flag = false;
        }

        if (timeout < timer & flag1)
        {
            timeout = 0;
            _userInterface.IntroText.text = "";
            flag1 = false;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.collider.gameObject.name == "RopeBridge1")
        {
            _userInterface.IntroText.text = "Special controls: R = Crawl | F = Wall glide";
            flag = true;
            flag1 = true;
        }
    }
}
