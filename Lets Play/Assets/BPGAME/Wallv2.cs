using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallv2 : MonoBehaviour
{

    float speed;
    float height;

    string input;
    public bool isUp;
    public bool isRight = false;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.localScale.y;
        speed = 5f;
    }

    public void Init(bool isUpWall, int wallpos)
    {
        isUp = isUpWall;

        Vector2 pos = Vector2.zero;
        if (isUp)
        {
            if (wallpos == 1)
            {
                pos = new Vector2(0, 5);
            }
        }
        else
        {
            if (wallpos == 2)
            {
                pos = new Vector2(0, -5);
              
            }
        }

        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}



    

