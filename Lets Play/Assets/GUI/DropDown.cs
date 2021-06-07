using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropDown : MonoBehaviour
{
    public static string totalplayers;

    public static void HandleInputData(int value)
    {
        if (value == 0)
        {
            totalplayers = "10";
        }
        else if (value == 1)
        {
            totalplayers = "12";
        }
        else if (value == 2)
        {
            totalplayers = "14";
        }
        else if (value == 3)
        {
            totalplayers = "16";
        }
        else if (value == 4)
        {
            totalplayers = "18";
        }
    }

}
