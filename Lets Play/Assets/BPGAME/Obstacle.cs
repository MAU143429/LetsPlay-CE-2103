using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Spawn(float x, float y)
    {
       
        Vector2 pos = new Vector2(x, y);
        this.GetComponent<RectTransform>().localPosition = pos;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            if (Ball.balldirection.x > 0)
            {
                Ball.balldirection.x = -Ball.balldirection.x;
            }

            if (Ball.balldirection.x < 0)
            {
                Ball.balldirection.x = -Ball.balldirection.x;

            }

            if (Ball.balldirection.y > 0)
            {
                Ball.balldirection.y = -Ball.balldirection.y;
            }

            if (Ball.balldirection.y < 0)
            {
                Ball.balldirection.y = -Ball.balldirection.y;

            }
        }
    }

}
