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

    public void LoadGameDoScene(int i){
        SceneManager.LoadScene("Scene_GameDO");
        numCaso = i;
    }

    public void GetMed()
    {
        pageHome.SetActive(false);
        pageLoad.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
