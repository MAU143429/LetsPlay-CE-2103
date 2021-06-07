using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    static TypeMessage typeMessageOut;

    public static void SpawnAllPlayers()
    {
        if (Input.GetKeyDown("l"))
        {
            bp_manager.Spawn_Players();
            
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        SpawnAllPlayers();
    }


}
