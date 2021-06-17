using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Game 
{
 
    public static void Select_Type_Game(TypeMessage response)
    {
        if(response.Game == "BPGAME")
        {
          
            bp_manager.Game_bp(response);
        }
        else
        {

        }   

    }



}
