using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool[] fases = new bool[3];
    public string name = null;

    public PlayerData(Player player){
        for (int i = 0; i < (player.fases).Length; i++)
        {
            fases[i] = player.fases[i];
        }
        this.name = player.name;
    }
}
