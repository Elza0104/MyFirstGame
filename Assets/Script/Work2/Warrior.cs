using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Warrior : MonoBehaviour
{
    public UI aos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
    }
    void OnCollisionEnter2D(Collision2D col)  //Archer�� ��ȣ�ۿ��� ���ۉ��� ��
    {
        Debug.Log("�Ʒ�");
        aos.
    }
}
