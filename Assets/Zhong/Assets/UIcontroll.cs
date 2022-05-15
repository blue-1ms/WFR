using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIcontroll : MonoBehaviour
{
    public Collider level1;
    public Collider level2;
    public Collider level3;
    public Collider level4;
    public RawImage image ;


    public void onclick1()
    {

        Debug.Log("1234");
        //Application.LoadLevel();
        SceneManager.LoadScene("Dungeon_Stylized_PrefabLayout");
        image.transform.localScale = new Vector3(0, 0, 0);
    }
    public void onclick2()
    {

        Debug.Log("1234");
        SceneManager.LoadScene("Dungeon_Stylized_PrefabLayout");
        image.transform.localScale = new Vector3(0, 0, 0);
    }
    public void onclick3()
    {

        Debug.Log("1234");
        SceneManager.LoadScene("Dungeon_Stylized_PrefabLayout");
        image.transform.localScale = new Vector3(0, 0, 0);
    }
    public void onclick4()
    {

        Debug.Log("1234");
        SceneManager.LoadScene("Dungeon_Stylized_PrefabLayout");
        image.transform.localScale = new Vector3(0, 0, 0);

    }

    private float time;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == level1.gameObject.name && other.gameObject.name == level2.gameObject.name
            && other.gameObject.name == level3.gameObject.name && other.gameObject.name == level4.gameObject.name)
        {
            time += Time.deltaTime;
            if (time > 1.5)
            {
                image.transform.localScale = new Vector3(1, 1, 1);
            }

        }
       
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     
    }
}
