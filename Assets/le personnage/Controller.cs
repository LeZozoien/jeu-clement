using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class Controller : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public Animator animator;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        float angle_du_vect = Mathf.Atan2(h, V) * Mathf.Rad2Deg / 360;
        angle_du_vect = angle_du_vect + 0.5f;

        rb2d.velocity = new Vector2(h, V).normalized * speed;
        animator.SetFloat("Angle", angle_du_vect);


    }
}
