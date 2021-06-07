using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Ball2 : MonoBehaviour
{
    float radius;
    public static Sprite ball21;
    public static Sprite ball22;
    public static SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        radius = transform.localScale.x / 2;
        spriteRenderer = GetComponent<SpriteRenderer>();
        

    }

    public  void Hide_Ball2()
    {
        spriteRenderer.sprite = ball22;
    }


    public  void Appear_Ball2()
    {
        spriteRenderer.sprite = ball21;
    }

    // Update is called once per frame
    void Update()
    {
        GameManager.Ball2 = transform.position;
        

       
    }

    public  void Spawn(float x , float y)
    {
        transform.position = new Vector2(x, y);
    }
    
}
