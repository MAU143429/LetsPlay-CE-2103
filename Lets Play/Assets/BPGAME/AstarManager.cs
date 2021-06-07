using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstarManager : MonoBehaviour
{
    public bool sendMessage = false;
    public bool a_enable = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Ball.getSpeed() == 0 && !sendMessage)
        {
            Astar();
            sendMessage = true;
        }
        else if (Ball.getSpeed() != 0)
        {
            sendMessage = false;
            Disapear_Astar();
            
        }


        if (Input.GetKeyDown("p") && GameManager.ballspeed == 0)
        {
            Astar_Animation();

        }
    }

    public void Astar_Animation()
    {

        int currentx, currenty;
        float spawnx, spawny;
        
        for (int i = 0; i < bp_manager.Astar_List.Count; i++)
        {
            currentx = bp_manager.Astar_List[i].posx;
            currenty = bp_manager.Astar_List[i].posy;

            spawnx = Bp_matrix.bp_matrix[currentx][currenty].posx;
            spawny = Bp_matrix.bp_matrix[currentx][currenty].posy;

            GameManager.List_balls[i].Spawn(spawnx, spawny);

        }


    }

    public void Disapear_Astar()
    {
        for (int i = 0; i < bp_manager.Astar_List.Count; i++)
        {
            GameManager.List_balls[i].Spawn(10, 10);
        }
    }

    public static void Astar()
    {

        Bp_matrix.Identify_Cell();
        if (!StartGameBP.hasAi && Turns.current_turn == 1)
        {
            TypeMessage typeMessageOut;
            typeMessageOut = new TypeMessage
            {
                Game = "BPGAME",
                Gamemode = "PvP",
                Player = "1",
                Totalplayers = DropDown.totalplayers,
                Currentposx = Bp_matrix.cell_x.ToString(),
                Currentposy = Bp_matrix.cell_y.ToString(),
                Initmode = "FALSE",
                isAi = "FALSE"

            };
            string messageToSend = JsonConvert.SerializeObject(typeMessageOut);
            Client.SendString(messageToSend);

        }
        else if (!StartGameBP.hasAi)
        {
            TypeMessage typeMessageOut;
            typeMessageOut = new TypeMessage
            {
                Game = "BPGAME",
                Gamemode = "PvP",
                Player = "2",
                Totalplayers = DropDown.totalplayers,
                Currentposx = Bp_matrix.cell_x.ToString(),
                Currentposy = Bp_matrix.cell_y.ToString(),
                Initmode = "FALSE",
                isAi = "FALSE"

            };
            string messageToSend = JsonConvert.SerializeObject(typeMessageOut);
            Client.SendString(messageToSend);
        }
        else
        {
            TypeMessage typeMessageOut;
            typeMessageOut = new TypeMessage
            {
                Game = "BPGAME",
                Gamemode = "PvAi",
                Player = " ",
                Totalplayers = DropDown.totalplayers,
                Currentposx = Bp_matrix.cell_x.ToString(),
                Currentposy = Bp_matrix.cell_y.ToString(),
                Initmode = "FALSE",
                isAi = "TRUE"

            };
            string messageToSend = JsonConvert.SerializeObject(typeMessageOut);
            Client.SendString(messageToSend);
        }

    }
}
