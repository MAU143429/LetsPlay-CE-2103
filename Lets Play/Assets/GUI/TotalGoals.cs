using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalGoals : MonoBehaviour
{
    public static int totalgoals;

    public static void HandleInputData(string value)
    {
        totalgoals = Int32.Parse(value);
    }
}
