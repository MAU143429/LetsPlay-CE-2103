using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Arrow : MonoBehaviour
{
    bool stop = false;
    bool f_time = true;
    bool select = false;
    public Sprite arrow1;
    public Sprite arrow0;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        faceMouse();
        transform.position = GameManager.Ball;

        if (Ball.getSpeed() == 0 && f_time == false)
        {
            spriteRenderer.sprite = arrow1;
            if (!select)
            {
                stop = false;
            }
            
       
        }
        else
        {
            spriteRenderer.sprite = arrow0;
            f_time = false;
            select = false;
            
        }
    }
    void faceMouse()
    {   
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        if (Input.GetMouseButtonDown(0) && !stop)
        {
           
            stop = true;
            select = true;
            Vector2 final_direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
            );
            transform.up = final_direction;
            GameManager.Arrow = final_direction;

        }
        else if(!stop)
        {
            Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

            transform.up = direction;
            
        }
        
       

        
    }


}
