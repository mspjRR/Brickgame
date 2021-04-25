using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballscript : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool inplay;
    public Transform paddle;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!inplay)
        {
            transform.position = paddle.position;
        }
        if (Input.GetButtonDown ("Jump") && !inplay)
        {
            inplay = true;
            rb.AddForce(Vector2.up * 500);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("bottom"))
        {
           
            rb.velocity = Vector2.zero;
            inplay = false;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("brick"))
        {
            Destroy(other.gameObject);
        }
    }
}
