using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public bool caso1 = true;
    public bool caso2 = false;
    public bool caso3 = false;
    public string name = null;

    public PlayerData(Player player){
        // for (int i = 0; i < (player.fases).Length; i++)
        // {
        //     fases[i] = player.fases[i];
        // }
        caso1 = player.caso1;
        caso2 = player.caso2;
        caso3 = player.caso3;
        this.name = player.nome;
    }
}
