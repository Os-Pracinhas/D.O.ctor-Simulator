using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance = null;
    public GameObject OpenWindowNameDr;
    private string sceneName;
    public int numCaso;

    public GameObject pageHome;
    public GameObject pageLoad;
    public GameObject pageLoadLevel;
    public GameObject pageOptions;

    Scene sce;

    public Caso caso;

    void Start()
    {
        if (instance == null) { instance = this; }
        else if (instance != this) { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);
        sce = SceneManager.GetActiveScene();

        for(int i = 0; i < (sce.GetRootGameObjects() as GameObject[]).Length; i++){
            Debug.Log((sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(1).gameObject.transform.GetChild(0));
        }
    }

    void Update(){
        if(Input.GetKeyDown("escape")){
            Debug.Log("yes");
        }
    }

    public void savecasoo(){
        NCaso casos = new NCaso();
        // casos.SaveCaso();
        Debug.Log(casos.LoadCaso().Count);
    }

    public void LoadGameDoScene(int numCaso){
        SceneManager.LoadScene("Scene_GameDO");
        NCaso casos = new NCaso();
        caso = casos.LoadCaso()[numCaso];
        this.numCaso = numCaso;
    }

    public void LoadSceneNivel()
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
