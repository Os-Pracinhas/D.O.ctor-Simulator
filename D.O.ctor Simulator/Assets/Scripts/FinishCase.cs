using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishCase : MonoBehaviour
{
    GameController gC;
    Player player;
    // Start is called before the first frame update
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
        gC.LoadSceneNivel();
    }

    public void SceneGoWrong(){
        gC.LoadSceneNivel();
    }

}
