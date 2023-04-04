using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hit : MonoBehaviour
{
    TextMeshProUGUI tt;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        tt = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreUp(int value)
    {
        Debug.Log("¾Æ·¡");
        score += value;
        tt.text = "Hit - " + score;
    }
}
