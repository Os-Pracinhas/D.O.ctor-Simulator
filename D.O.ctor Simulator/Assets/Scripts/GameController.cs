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

    public Caso caso;

    void Start()
    {
        if (instance == null) { instance = this; }
        else if (instance != this) { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);
    }

    void Update(){
        
    }

    public void SetNewMed()
    {
        OpenWindowNameDr.SetActive(true);
    }

    public void FecharBg()
    {
        OpenWindowNameDr.SetActive(false);
    }

    public void LoadGameDoScene(int numCaso){
        SceneManager.LoadScene("Scene_GameDO");
        NCaso casos = new NCaso();
        caso = casos.LoadCaso()[numCaso];
    }

    public void LoadSceneNivel()
    {
        SceneManager.LoadScene("Scene_Home");
    }

    public void GetMed(GameObject content)
    {
        pageHome.SetActive(false);
        pageLoad.SetActive(true);

        FindObjectOfType<Player>().LoadPlayers(content);
    }

    public void VoltarHome()
    {
        pageLoad.SetActive(false);
        pageHome.SetActive(true);
    }
    public void VoltarLoad()
    {
        pageLoadLevel.SetActive(false);
        pageLoad.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void SetSelecionarNivel(PlayerData player){
        pageLoadLevel.SetActive(true);
        pageLoad.SetActive(false);
        if(!player.caso2){
            pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        }
        if(!player.caso3)pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void GetBackCarregarJogo(){
        pageLoadLevel.SetActive(false);
        pageLoad.SetActive(true);
    }
}
