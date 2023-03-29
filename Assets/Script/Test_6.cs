using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //나랑 물리적으로 충돌해서 if를 실행하지않을래?
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