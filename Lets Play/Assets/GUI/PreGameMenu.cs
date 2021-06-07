using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;
using System.Threading;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;

public class PreGameMenu : MonoBehaviour
{
    TypeMessage typeMessageOut;
    public void StartGPGAME()
    {
        typeMessageOut = new TypeMessage
        {
            Game = "GPUZZLE",
            Gamemode = " ",
            Player = " ",
            Totalplayers = " ",
            Currentposx = " ",
            Currentposy = " ",
            Initmode = "TRUE",
            isAi = " "

        };

        Client.Init();
        string messageToSend = JsonConvert.SerializeObject(typeMessageOut);
        Client.SendString(messageToSend);
        Thread.Sleep(1000);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void open()
    {
       string path = EditorUtility.OpenFilePanel("Select one image to open", "", "png");
        if (path.Length != 0)
        {
            var fileContent = File.ReadAllBytes(path);
            Debug.Log(fileContent);
        }
    }

}


