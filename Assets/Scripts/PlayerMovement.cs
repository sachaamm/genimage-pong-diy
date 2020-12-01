using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;

    private float movement;
    // Start is called before the first frame update
    void Start()
    {
        restartPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
        {
            movement = (Input.GetAxisRaw("Vertical"));
        }
        else
        {
            movement = (Input.GetAxisRaw("Vertical2"));
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
    public Vector3 restartPos;

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = restartPos;
    }

}
