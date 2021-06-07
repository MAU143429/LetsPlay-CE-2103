using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Force : MonoBehaviour
{
    Text porcentageText;

    // Start is called before the first frame update
    void Start()
    {
        porcentageText = GetComponent<Text>();
        
    }

    public void textUpdate(float value)
    {
        GameManager.force = value;
        porcentageText.text = Mathf.RoundToInt((value * 100) / 10) + "%";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
