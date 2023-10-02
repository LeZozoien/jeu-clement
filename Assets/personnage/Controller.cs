using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Controller : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * speed;
        float V = Input.GetAxis("Vertical") * speed;

        rb2d.velocity = new Vector2(h, V);
  
    }
}
