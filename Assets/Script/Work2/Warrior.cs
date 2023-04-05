using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Warrior : MonoBehaviour
{
    public GameObject aos;
    TextMeshProUGUI sos;
    int score;
    int value;
    // Start is called before the first frame update
    void Start()
    {
        
        sos = aos.GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
    }
    
    void OnCollisionEnter2D(Collision2D col)  //Archer와 상호작용이 시작됬을 때
    {
        
        if (col.gameObject.tag == "Arrow")
        {
            score += value;
            sos.text = "qt " + value;
        }
        

    }
}
