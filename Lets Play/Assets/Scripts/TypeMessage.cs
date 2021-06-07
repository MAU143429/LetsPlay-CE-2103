using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeMessage
{
    public string Game { get; set; }

    public string Gamemode { get; set; }

    public string Player { get; set; }

    public string Totalplayers { get; set; }

    public string Currentposx { get; set; }

    public string Currentposy { get; set; }

    public string Initmode { get; set; }

    public string isAi { get; set; }

    public List<Box_R> Playerlist {get; set;}

    public List<Box_R> AStarList { get; set; }


}
