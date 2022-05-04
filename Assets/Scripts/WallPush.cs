using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class WallPush : MonoBehaviour
{
    public bool wallPush;
    public LayerMask pushLayers;

    private CharacterController character;

    private Vector3 pushDir = Vector3.zero;

    private Vector3 playerVelocity;

    private bool flag = false;
    
    private void Start()
    {
        character = GetComponent<CharacterController>();
        
    }

    private void Update()
    {
        /*
        if (!flag)
        {
            
        }
        
        if (flag) // && button is pressed
        {
            pushDir.x += 5;
            
            flag = false;
        }
        
        character.Move(pushDir * Time.deltaTime);
        */
   
    }
    
    

}
