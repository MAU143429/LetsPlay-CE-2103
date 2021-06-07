using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Turns : MonoBehaviour
{
    public static int current_turn;
    public Sprite player1;
    public Sprite player2;
    public SpriteRenderer spriteRenderer;
    static bool turn1, turn2;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-7.750f, -4.701475f);
        spriteRenderer = GetComponent<SpriteRenderer>();
        current_turn = 1;
        turn1 = true;
        turn2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        Turns_method();
    }

    public static void current_player()
    {
        if(turn1 == true)
        {
            turn1 = false;
            turn2 = true;
            current_turn = 2;

        }
        else if (turn2 == true)
        {
            turn1 = true;
            turn2 = false;
            current_turn = 1;
        }
            
    }

    public void Turns_method()
    {
        
        if(turn1 == true)
        {
            spriteRenderer.sprite = player1;
        }
        if(turn2 == true)
        {
            spriteRenderer.sprite = player2;
        }

    }
}
