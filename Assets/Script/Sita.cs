using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sita : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("�Ʒ�");
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
}
