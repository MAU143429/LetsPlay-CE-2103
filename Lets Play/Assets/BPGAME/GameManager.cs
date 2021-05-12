using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Wall wall;
    public Wallv2 wallv2;

    public static Vector2 WallLeft;
    public static Vector2 WallLeft1;
    public static Vector2 WallRight;
    public static Vector2 WallRight1;
    public static Vector2 WallUp;
    public static Vector2 WallDown;

    void OnGUI()
    {
        GUI.Label(new Rect(100, 100, 100, 100), "AQUI VA EL MARCADOR Y LOS EQUIPOS!");
    }
    // Start is called before the first frame update
    void Start()
    {
        WallLeft = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        WallLeft1 = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        WallRight = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        WallRight1 = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        WallUp = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        WallDown = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));


        Instantiate(ball);
        


        Wall wall1 = Instantiate(wall) as Wall;
        Wall wall2 = Instantiate(wall) as Wall;
        Wall wall3 = Instantiate(wall) as Wall;
        Wall wall4 = Instantiate(wall) as Wall;
        Wallv2 wallup = Instantiate(wallv2) as Wallv2;
        Wallv2 walldown = Instantiate(wallv2) as Wallv2;

        wall1.Init(true, 1);
        wall2.Init(true, 2);
        wall3.Init(false, 3);
        wall4.Init(false, 4);
        wallup.Init(true, 1);
        walldown.Init(false, 2);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

