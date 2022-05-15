using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movehor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed ;
    private bool movingRight = true;
    void Update()
    {
         
        
    }
    private void FixedUpdate()
    {
        if (movingRight)
        {
            
            transform.Translate(Vector3.forward* speed * Time.deltaTime);


            if (transform.position.z >=-56)
            {
                movingRight = false;
            }
        }
        else
        {
           
            transform.Translate(Vector3.back* speed * Time.deltaTime);

           
            if (transform.position.z <=-72)
            {
                movingRight = true;
            }
        }


    }
}
