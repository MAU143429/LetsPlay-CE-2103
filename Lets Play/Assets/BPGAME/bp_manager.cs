using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bp_manager : MonoBehaviour
{
    public static List<Box_R> Spaw_List = new List<Box_R>();
    public static List<Box_R> Astar_List = new List<Box_R>();
    public static int numastar = 1;
    public static void Game_bp(TypeMessage response)
    {
        if (response.Initmode == "TRUE")
        {
            Spaw_List = response.Playerlist;

        }
        else
        {
            Astar_List = response.AStarList;
            Debug.Log("RECIBIDO A STAR NUMERO --> " + numastar);
            numastar++;
           
        }
    }



    public static void Spawn_Players()
    {
        int currentx, currenty;
        int cont1 = 0;
        int cont2 = 0;
        float spawnx, spawny;
        for (int i = 0; i < Spaw_List.Count; i++)
        {
            currentx = Spaw_List[i].posx;
            currenty = Spaw_List[i].posy;

            spawnx = Bp_matrix.bp_matrix[currentx][currenty].posx;
            spawny = Bp_matrix.bp_matrix[currentx][currenty].posy;

            if(currenty <= 8)
            {
                GameManager.List_p1[cont1].Spawn(spawnx, spawny);
                cont1++;
            }
            else if (currenty > 8)
            {
                GameManager.List_p2[cont2].Spawn(spawnx, spawny);
                cont2++;
            }

           
            
        }


    }
}
