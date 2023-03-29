using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_3 : MonoBehaviour
{
    public float GameVelue;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(gameObject.name+"is dead");
        Debug.Log(transform.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
