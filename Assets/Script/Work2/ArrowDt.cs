using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 0.000001f);
    }
}
