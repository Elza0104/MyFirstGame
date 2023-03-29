using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class archer : MonoBehaviour
{
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey(KeyCode.J))
        {
            position.x += -5f * speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.L))
        {
            position.x += +5f * speed * Time.deltaTime;
        }
        transform.position = position;
    }
}