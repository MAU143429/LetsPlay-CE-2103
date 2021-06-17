using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;


public class Turns : MonoBehaviour
{
    public static int current_turn;
    public Sprite player1;
    public Sprite player2;
    public Sprite ai;
    public SpriteRenderer spriteRenderer;
    public static bool turn1, turn2, turnai,Ai_Astar;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-7.750f, -4.701475f);
        spriteRenderer = GetComponent<SpriteRenderer>();
        current_turn = 1;
        turn1 = true;
        turnai = false;
        turn2 = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Init_Turn == true)
        {
            Turns_method();
            if (Ball.getSpeed() == 0)
            {
                
                if (turnai == true)
                {
                    
                    Ai_Astar = true;
                    StartCoroutine(Astar_timer());
                    StartCoroutine(Ai_turn());
                    turnai = false;
                    turn1 = true;
                    current_turn = 1;
                }
            }
            
        }

    }

    public static IEnumerator Ai_turn()
    {
            yield return new WaitForSeconds(5);
            Ball.Auto_Hit();
    }
    public IEnumerator Astar_timer()
    {
        yield return new WaitForSeconds(3);
        AstarManager.Astar_Animation();
        Arrow.Ai_turn = true;
    }

    public static void current_player()
    {
        if(GameManager.Init_Turn)
        {
            if (StartGameBP.hasAi == true)
            {
                if (turn1 == true)
                {
                    turn1 = false;
                    turnai = true;
                    current_turn = 3;

                }
                
            }
            else
            {
                if (turn1 == true)
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
        if (turnai == true)
        {
            spriteRenderer.sprite = player2;
        }

    }

    public static void Restart()
    {
        current_turn = 1;
        turn1 = true;
        turnai = false;
        turn2 = false;
    }
}
