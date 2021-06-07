using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    static float speed;
    float radius;
    public static Vector2 balldirection;
    static Vector2 initial_direction = new Vector2(0,0);

    // Start is called before the first frame update
    void Start()
    {
        balldirection = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
       


    }

    public void Hit_ball()
    {
       
        speed = GameManager.force;
        balldirection = GameManager.Arrow;
        Turns.current_player();
    }

    public static float getSpeed()
    {
        return speed;
    }



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            speed = 0;
        }


        // Asigna la posicion general y da movimiento.
        GameManager.Ball = transform.position;
        transform.Translate(balldirection * speed * Time.deltaTime);
        GameManager.ballspeed = speed;


        // Hitbox superior
        if (transform.position.y < GameManager.WallLeft.y + radius + 0.6 && balldirection.y < 0)
        {
            balldirection.y = -balldirection.y;
            if (speed < 1)
            {
                speed = 0f;
            }
            else
            {
                speed -= 1f;
            }
        }
        // Hitbox inferior
        if (transform.position.y > GameManager.WallRight.y - radius - 0.5 && balldirection.y > 0)
        {
            balldirection.y = -balldirection.y;
            if (speed < 1)
            {
                speed = 0f;
            }
            else
            {
                speed -= 1f;
            }
        }

        // Detecta gol del lado izquierdo
        if (transform.position.x < GameManager.WallLeft.x + radius + 0.1 && balldirection.x < 0)
        {
            transform.position = new Vector2(0, 0);
            speed = 0;
            m2.scoreUpdate2();
            Debug.Log("GOAL RIGHT PLAYER WINS!");

            
        }
        // Detecta gol del lado derecho
        if (transform.position.x > GameManager.WallRight.x - radius - 0.1 && balldirection.x > 0)
        {
            transform.position = new Vector2(0, 0);
            speed = 0;
            m1.scoreUpdate1();
            Debug.Log("GOAL LEFT PLAYER WINS!");
            
        }

        
        /**
       
        if (transform.position.y < GameManager.WallLeft1.y + radius && balldirection.y < 0)
        {
            balldirection.y = -balldirection.y;
        }

        
        if (transform.position.y > GameManager.WallRight1.y - radius && balldirection.y > 0)
        {
            balldirection.y = -balldirection.y;
        }
        */
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Wall")
        {
            bool isRight = other.GetComponent<Wall>().isRight;

            if (isRight && balldirection.x > 0)
            {
                balldirection.x = -balldirection.x;
                if(speed < 1)
                {
                    speed = 0f;
                }
                else
                {
                    speed -= 1f;
                }
                
            }

            if (!isRight && balldirection.x < 0)
            {
                balldirection.x = -balldirection.x;
                if (speed < 1)
                {
                    speed = 0f;
                }
                else
                {
                    speed -= 1f;
                }

            }
        }
    }

}
