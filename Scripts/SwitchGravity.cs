using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    private Rigidbody2D rb;


    private bool top;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rb.gravityScale *= -1;
            Rotation();
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            rb.gravityScale *= -1;
            Rotation();
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.gravityScale *= -1;
            Rotation();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            rb.gravityScale *= -1;
            Rotation();
        }
    }

    void Rotation()
    {
        if (top == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 180f);

        }

        else
        {
            transform.eulerAngles = Vector3.zero;
        }
        top = !top;


    }
}
