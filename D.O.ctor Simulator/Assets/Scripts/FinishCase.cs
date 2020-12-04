using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishCase : MonoBehaviour
{
 
    GameController gC;
    Player player;
    void Start()
    {
        gC = FindObjectOfType<GameController>();
        player = FindObjectOfType<Player>();
    }

    public void SceneSelectedNivel()
    {
        if(gC.numCaso == 0) player.caso2 = true;
        else if(gC.numCaso == 1)player.caso3 = true;
        player.SalvarProg();
        gC.LoadScenePosGaeDO();
    }

    public void SceneGoWrong(){
        gC.LoadScenePosGaeDO();
    }

}
