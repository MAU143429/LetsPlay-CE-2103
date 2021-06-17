using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Wall wall;
    public Arrow arrow;
    public Ball2 ball2;
    public Turns turn;
    public Obstacle obs1;
    public Obstacle obs2;
   
    public static float force;
    public static float ballspeed;
    public static List<Obstacle> List_p1 = new List<Obstacle>();
    public static List<Obstacle> List_p2 = new List<Obstacle>();
    public static List<Ball2> List_balls = new List<Ball2>();
    public static bool Init_Turn;


    public static Vector2 WallLeft;
    public static Vector2 WallLeft1;
    public static Vector2 WallRight;
    public static Vector2 WallRight1;
    public static Vector2 Ball;
    public static Vector2 Ball2;
    public static Vector2 Arrow;
    public static Vector2 Turn;

    // Start is called before the first frame update
    void Start()
    {

        
        WallLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        WallLeft1 = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        WallRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        WallRight1 = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        Instantiate(ball);
        Instantiate(arrow);
        Instantiate(turn);
        
        Obstacle obstacle1 = Instantiate(obs1) as Obstacle; 
        Obstacle obstacle2 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle3 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle4 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle5 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle6 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle7 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle8 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle9 = Instantiate(obs1) as Obstacle;
        Obstacle obstacle10 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle11 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle12 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle13 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle14 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle15 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle16 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle17 = Instantiate(obs2) as Obstacle;
        Obstacle obstacle18 = Instantiate(obs2) as Obstacle;
        obstacle1.Spawn(10, 10);
        obstacle2.Spawn(10, 10);
        obstacle3.Spawn(10, 10);
        obstacle4.Spawn(10, 10);
        obstacle5.Spawn(10, 10);
        obstacle6.Spawn(10, 10);
        obstacle7.Spawn(10, 10);
        obstacle8.Spawn(10, 10);
        obstacle9.Spawn(10, 10);
        obstacle10.Spawn(10, 10);
        obstacle11.Spawn(10, 10);
        obstacle12.Spawn(10, 10);
        obstacle13.Spawn(10, 10);
        obstacle14.Spawn(10, 10);
        obstacle15.Spawn(10, 10);
        obstacle16.Spawn(10, 10);
        obstacle17.Spawn(10, 10);
        obstacle18.Spawn(10, 10);
        List_p1.Add(obstacle1);
        List_p1.Add(obstacle2);
        List_p1.Add(obstacle3);
        List_p1.Add(obstacle4);
        List_p1.Add(obstacle5);
        List_p1.Add(obstacle6);
        List_p1.Add(obstacle7);
        List_p1.Add(obstacle8);
        List_p1.Add(obstacle9);
        List_p2.Add(obstacle10);
        List_p2.Add(obstacle11);
        List_p2.Add(obstacle12);
        List_p2.Add(obstacle13);
        List_p2.Add(obstacle14);
        List_p2.Add(obstacle15);
        List_p2.Add(obstacle16);
        List_p2.Add(obstacle17);
        List_p2.Add(obstacle18);

        Ball2 b1 = Instantiate(ball2) as Ball2;
        Ball2 b2 = Instantiate(ball2) as Ball2;
        Ball2 b3 = Instantiate(ball2) as Ball2;
        Ball2 b4 = Instantiate(ball2) as Ball2;
        Ball2 b5 = Instantiate(ball2) as Ball2;
        Ball2 b6 = Instantiate(ball2) as Ball2;
        Ball2 b7 = Instantiate(ball2) as Ball2;
        Ball2 b8 = Instantiate(ball2) as Ball2;
        Ball2 b9 = Instantiate(ball2) as Ball2;
        Ball2 b10 = Instantiate(ball2) as Ball2;
        Ball2 b11 = Instantiate(ball2) as Ball2;
        Ball2 b12 = Instantiate(ball2) as Ball2;
        Ball2 b13 = Instantiate(ball2) as Ball2;
        Ball2 b14 = Instantiate(ball2) as Ball2;
        Ball2 b15 = Instantiate(ball2) as Ball2;
        Ball2 b16 = Instantiate(ball2) as Ball2;
        Ball2 b17 = Instantiate(ball2) as Ball2;
        Ball2 b18 = Instantiate(ball2) as Ball2;
        Ball2 b19 = Instantiate(ball2) as Ball2;
        Ball2 b20 = Instantiate(ball2) as Ball2;
        Ball2 b21 = Instantiate(ball2) as Ball2;
        Ball2 b22 = Instantiate(ball2) as Ball2;
        Ball2 b23 = Instantiate(ball2) as Ball2;
        Ball2 b24 = Instantiate(ball2) as Ball2;
        Ball2 b25 = Instantiate(ball2) as Ball2;
        Ball2 b26 = Instantiate(ball2) as Ball2;
        Ball2 b27 = Instantiate(ball2) as Ball2;
        Ball2 b28 = Instantiate(ball2) as Ball2;
        Ball2 b29 = Instantiate(ball2) as Ball2;
        Ball2 b30 = Instantiate(ball2) as Ball2;
        b1.Spawn(10, 10);
        b2.Spawn(10, 10);
        b3.Spawn(10, 10);
        b4.Spawn(10, 10);
        b5.Spawn(10, 10);
        b6.Spawn(10, 10);
        b7.Spawn(10, 10);
        b8.Spawn(10, 10);
        b9.Spawn(10, 10);
        b10.Spawn(10, 10);
        b11.Spawn(10, 10);
        b12.Spawn(10, 10);
        b13.Spawn(10, 10);
        b14.Spawn(10, 10);
        b15.Spawn(10, 10);
        b16.Spawn(10, 10);
        b17.Spawn(10, 10);
        b18.Spawn(10, 10);
        b19.Spawn(10, 10);
        b20.Spawn(10, 10);
        b21.Spawn(10, 10);
        b22.Spawn(10, 10);
        b23.Spawn(10, 10);
        b24.Spawn(10, 10);
        b25.Spawn(10, 10);
        b26.Spawn(10, 10);
        b27.Spawn(10, 10);
        b28.Spawn(10, 10);
        b29.Spawn(10, 10);
        b30.Spawn(10, 10);
        List_balls.Add(b1);
        List_balls.Add(b2);
        List_balls.Add(b3);
        List_balls.Add(b4);
        List_balls.Add(b5);
        List_balls.Add(b6);
        List_balls.Add(b7);
        List_balls.Add(b8);
        List_balls.Add(b9);
        List_balls.Add(b10);
        List_balls.Add(b11);
        List_balls.Add(b12);
        List_balls.Add(b13);
        List_balls.Add(b14);
        List_balls.Add(b15);
        List_balls.Add(b16);
        List_balls.Add(b17);
        List_balls.Add(b18);
        List_balls.Add(b19);
        List_balls.Add(b20);
        List_balls.Add(b21);
        List_balls.Add(b22);
        List_balls.Add(b23);
        List_balls.Add(b24);
        List_balls.Add(b25);
        List_balls.Add(b26);
        List_balls.Add(b27);
        List_balls.Add(b28);
        List_balls.Add(b29);
        List_balls.Add(b30);



        Wall wall1 = Instantiate(wall) as Wall;
        Wall wall2 = Instantiate(wall) as Wall;
        Wall wall3 = Instantiate(wall) as Wall;
        Wall wall4 = Instantiate(wall) as Wall;

        wall1.Init(true, 1);
        wall2.Init(true, 2);
        wall3.Init(false, 3);
        wall4.Init(false, 4);

        Init_Turn = true;
         

    }



    // Update is called once per frame
    void Update()
    {
        End_Game();
        
       
    }

   


    public void End_Game()
    {
        if((m1.score1-1) == TotalGoals.totalgoals && EditorUtility.DisplayDialog("RESULTADO DE LA PARTIDA",
                "EL JUGADOR 1 HA GANADO", "OK", "CANCEL"))
        {
            m1.score1 = 0;
            MainMenu.RestartBPGAME();


        }
        else if ((m2.score2 - 1) == TotalGoals.totalgoals)
        {
            if (StartGameBP.hasAi == true && EditorUtility.DisplayDialog("RESULTADO DE LA PARTIDA",
                "EL AI HA GANADO", "OK", "CANCEL"))
            {
                m2.score2 = 0;
                MainMenu.RestartBPGAME();
            }
            else if(EditorUtility.DisplayDialog("RESULTADO DE LA PARTIDA",
                "EL JUGADOR 2 HA GANADO", "OK", "CANCEL"))
            {
                m2.score2 = 0;
                MainMenu.RestartBPGAME();
            }
            

        }
    }

    

}

