using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    Scene sce;
    public static GameController instance = null;
    public int numCaso;

    public GameObject pageLoad;
    public GameObject pageLoadLevel;

    public Caso caso;

    void Start()
    {
        if (instance == null) { instance = this; }
        else if (instance != this) { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);
    }

    public void LoadGameDoScene(int numCaso){
        SceneManager.LoadScene("Scene_GameDO");
        NCaso casos = new NCaso();
        caso = casos.LoadCaso()[numCaso];
        this.numCaso = numCaso;
    }

    public void LoadScenePosGaeDO()
    {
        SceneManager.LoadScene("Scene_PosGameDO");
    }

    public void LoadSceneHome()
    {
        SceneManager.LoadScene("Scene_Home");
    }

    public void SetSelecionarNivel(PlayerData player){
        sce = SceneManager.GetActiveScene();
        GameObject pageLoadLevel = (sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(1).gameObject.transform.GetChild(2).gameObject;
        pageLoadLevel.SetActive(true);
        (sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.SetActive(false);
        if(!player.caso2){
            pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        }
        if(!player.caso3)pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }
}
