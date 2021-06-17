using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private Rigidbody2D rb;
    public float halfup = 0.37f;
    public float halfdown = 0.50f;

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

            if (Ball.balldirection.x > (transform.position.x - halfdown))
            {
                Ball.balldirection.x = -Ball.balldirection.x;
                Ball.Change_speed();
            }

            if (Ball.balldirection.x < (transform.position.x - halfdown))
            {
                Ball.balldirection.x = -Ball.balldirection.x;
                Ball.Change_speed();
            }

            if (Ball.balldirection.y > (transform.position.y - halfup))
            {
                Ball.balldirection.y = -Ball.balldirection.y;
                Ball.Change_speed();
            }

            if (Ball.balldirection.y < (transform.position.y - halfup))
            {
                Ball.balldirection.y = -Ball.balldirection.y;
                Ball.Change_speed();
            }


        }
    }


}
