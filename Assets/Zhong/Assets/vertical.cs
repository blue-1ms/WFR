using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vertical : MonoBehaviour
{
    public float speed ;
    private bool movingRight = true;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //��������x��-5��5֮������ѭ���ƶ�
        if (movingRight)
        {
            //����������
            transform.Translate(Vector3.up* speed * Time.deltaTime);

            //������Ƶ���5����ô�������������ƣ����԰�������Ϊfalse
            if (transform.position.y >= 18)
            {
                movingRight = false;
            }
        }
        else
        {
            //���������ƣ�����x�����굽��-5��˵���������ƣ���ʼ����
            transform.Translate(Vector3.down* speed * Time.deltaTime);

            //���ƽ��������ƿ�ʼ������״̬Ϊtrue
            if (transform.position.y <= -2)
            {
                movingRight = true;
            }
        }
    }

}
