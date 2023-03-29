using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float Value; 
    // Start is called before the first frame update
    void Start()
    {
        
       

    }

    // Update is called once per frame
    void Update()
    {
        int A = 10;
        int B = 75;
        string name = "philip";

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log(A);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log(B);
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log(name);
        }
    }
}
