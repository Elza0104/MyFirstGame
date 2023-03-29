using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("À§");
        GetComponent<SpriteRenderer>().color = Color.gray;
    }
}
