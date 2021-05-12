using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    float speed;

    float radius;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.y < GameManager.WallLeft.y + radius && direction.y < 0)
        {
            direction.y = -direction.y;
        }

        if (transform.position.y < GameManager.WallLeft1.y + radius && direction.y < 0)
        {
            direction.y = -direction.y;
        }

        if (transform.position.y > GameManager.WallRight.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;
        }
        if (transform.position.y > GameManager.WallRight1.y - radius && direction.y > 0)
        {
            direction.y = -direction.y;
        }

        // prueba muro 
        
        if (transform.position.x < GameManager.WallUp.x + radius && direction.x < 0)
        {
            direction.x = -direction.x;
        }

        if (transform.position.x < GameManager.WallDown.x + radius && direction.x < 0)
        {
            direction.x = -direction.x;
        }
        //

        if (transform.position.x < GameManager.WallLeft.x + radius && direction.x < 0)
        {
            Debug.Log("GOAL RIGHT PLAYER WINS!");
            Time.timeScale = 0;
        }

        if (transform.position.x > GameManager.WallRight.x - radius && direction.x > 0)
        {
            Debug.Log("GOAL LEFT PLAYER WINS!");
            Time.timeScale = 0;
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            bool isRight = other.GetComponent<Wall>().isRight;
            bool isUp = other.GetComponent<Wallv2>().isUp;

            if (isRight && direction.x > 0)
            {
                direction.x = -direction.x;
            }

            if (!isRight && direction.x < 0)
            {
                direction.x = -direction.x;
            }

            if (isUp && direction.y > 0)
            {
                direction.y = -direction.y;
            }

            if (!isUp && direction.y < 0)
            {
                direction.y = -direction.y;
            }
        }
    }

}
