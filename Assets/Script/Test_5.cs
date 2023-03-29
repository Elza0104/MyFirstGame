using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_5 : MonoBehaviour
{
   
    int frame = 0;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        frame++;//frame = frame + 1;


        if (frame % 60 == 0)
        { 
            Debug.Log("oh!");
        }
    }
}
