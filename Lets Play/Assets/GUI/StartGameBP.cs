using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;

public class StartGameBP : MonoBehaviour
{
    TypeMessage typeMessageOut;
    public static string bp_gamemode;
    public static bool hasAi;
    public void StartPvP()
    {
        Bp_matrix.Fill_Matrix();
        Client.Init();
        typeMessageOut = new TypeMessage
        {
            Game = "BPGAME",
            Gamemode = "PvP",
            Player = " ",
            Totalplayers = DropDown.totalplayers,
            Currentposx = " ",
            Currentposy = " ",
            Initmode = "TRUE",
            isAi = "FALSE"

        };
        string messageToSend = JsonConvert.SerializeObject(typeMessageOut);
        Client.SendString(messageToSend);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        
        
        
    }

    public void StartAi()
    {
        Bp_matrix.Fill_Matrix();
        hasAi = true;
        Client.Init();
        typeMessageOut = new TypeMessage
        {
            Game = "BPGAME",
            Gamemode = "PvAi",
            Player = " ",
            Totalplayers = DropDown.totalplayers,
            Currentposx = " ",
            Currentposy = " ",
            Initmode = "TRUE",
            isAi = "FALSE"

        };
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        string messageToSend = JsonConvert.SerializeObject(typeMessageOut);
        Client.SendString(messageToSend);

    }

}
