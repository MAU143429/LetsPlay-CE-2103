using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class m2 : MonoBehaviour
{

    static Text scoreText2;
    public static int score2 = 1;
    // Start is called before the first frame update
    void Start()
    {
        scoreText2 = GetComponent<Text>();
    }

    public static void scoreUpdate2()
    {
        scoreText2.text = score2.ToString();
        score2++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
