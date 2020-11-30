using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public bool[] fases = {true, false, false};
    public string name = null;

    public void SavePlayer(Text n){
        name = n.text;
        SaveSystem.SavePlayer(this);
        FindObjectOfType<GameController>().LoadGameDoScene(1);
    }

    public void LoadPlayer(){
        PlayerData data = SaveSystem.LoadPlayer();
        for (int i = 0; i < (data.fases).Length; i++)
        {
            this.fases[i] = data.fases[i];
        }
    }
}
