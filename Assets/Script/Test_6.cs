using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� ���������� �浹�ؼ� if�� ��������������?
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(gameObject);
        }
    }
}