using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer1 : MonoBehaviour
{
    //히히 화살발사
    public GameObject ArrowObj;
    public Transform shootPostf;
    public KeyCode shootingKey;
    public int power;
    SpriteRenderer Sr;

    // Start is called before the first frame update
    void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
        Debug.Log(ArrowObj.name);
        Debug.Log(shootPostf.position);
        Debug.Log("MyKey " + shootingKey);
        Debug.Log("power " + power);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("JUMP!");
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000f);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Debug.Log("LEFT!");
            Sr.flipX = false;
            transform.Translate(-0.05f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Debug.Log("migi!");
            Sr.flipX = true;
            transform.Translate(0.05f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GameObject ArrowClone = Instantiate(ArrowObj);
            ArrowClone.transform.position = shootPostf.position;
            //ArrowClone.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 300f);
        }
    }
}
