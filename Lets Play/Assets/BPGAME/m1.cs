using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class m1 : MonoBehaviour
{
    static Text scoreText1;
    public static int score1 = 1;
     
    // Start is called before the first frame update
    void Start()
    {
        scoreText1 = GetComponent<Text>();
    }

    public static void scoreUpdate1()
    {
        scoreText1.text = score1.ToString();
        score1 ++;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
