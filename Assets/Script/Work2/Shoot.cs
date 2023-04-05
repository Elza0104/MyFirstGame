using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject ArrowObj;
    public Transform shootPostf;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void St()
    {
        Debug.Log("qwhdqwd");
        GameObject Arrow1Clone = Instantiate(ArrowObj);
        Arrow1Clone.transform.position = shootPostf.position;
        Arrow1Clone.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -1) * 2000f);
    }

}
