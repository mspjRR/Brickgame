using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlescript : MonoBehaviour
{
    public float speed;
    public float rightscreenedge;
    public float leftscreenedge;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* float mousepos = Input.mousePosition.x / Screen.width * 16.0f;
         Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
         paddlePos.x = Mathf.Clamp(mousepos, 0, 11);
         transform.position = paddlePos;*/
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontal*Time.deltaTime*speed);
        if(transform.position.x < leftscreenedge)
        {
           transform.position = new Vector2 (leftscreenedge, transform.position.y);
        }
        if (transform.position.x > rightscreenedge)
        {
            transform.position = new Vector2 (rightscreenedge, transform.position.y);
        }

    }
}
