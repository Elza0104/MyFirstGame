using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Calculator(3, 7);
        int value = PLUS(3, 5);
        int v = PLUS(5, 5);
        int value2 = PLUS(3, v);
        int value3 = 8 + 10;
        

        Debug.Log("value = " + value);
        Debug.Log("value = " + value2);
        Debug.Log("value = " + value3);
    }

    private int PLUS(int v1, int v2)
    {
        int v = v1 + v2;
        return v;
    }

    private void Calculator(int v1, int v2)
    {
        Debug.Log("start");
        Debug.Log("v1 + v2="+ (v1 + v2));
        Debug.Log("v1 + v2="+(v1 - v2));
        Debug.Log("v1 + v2="+(v1 * v2));
        Debug.Log("v1 + v2="+(v1 / v2));
        Debug.Log("v1 + v2 ="+(v1 % v2));//퍼센트(모듈러스:나머지)
        Debug.Log("end");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
