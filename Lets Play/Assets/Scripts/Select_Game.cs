using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_Game 
{
 
    public static void Select_Type_Game(TypeMessage response)
    {
        if(response.Game == "BPGAME")
        {
            Debug.Log("SOY LA RESPUESTA DEL SERVER Y VOY PARA EL CONTROLLER DE BPGAME");
            bp_manager.Game_bp(response);
        }
        else
        {

        }   

    }



}
