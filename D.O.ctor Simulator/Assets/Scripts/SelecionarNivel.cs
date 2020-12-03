using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelecionarNivel : MonoBehaviour
{
    // public Button buttonPageHome;
    // public static SelecionarNivel sele;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     sele = new SelecionarNivel();
    //     buttonPageHome.onClick.AddListener(delegate { LoadSceneHome(); });
    // }
    public void LoadSceneHome()
    {
        SceneManager.LoadScene("Scene_Home");
    }
}
