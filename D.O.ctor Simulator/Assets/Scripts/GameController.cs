using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject nameDr;
    private string sceneName;
    public int numCaso;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void SetNewMed()
    {
        nameDr.SetActive(true);
    }

    public void LoadGameDoScene(int i){
        SceneManager.LoadScene("GameDoScene");
        numCaso = i;
    }
}
