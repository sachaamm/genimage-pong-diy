using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector3 restartPos;

    // Start is called before the first frame update
    void Start()
    {
        restartPos = transform.position;
        Launch();
    }
    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = restartPos;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        rb.velocity = new Vector2(speed * x, speed * y);
    }
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
