using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PosGame : MonoBehaviour
{
    public Button buttonPageHome;

    public GameObject pageInicial;
    public GameObject pageLoadNivel;

    public GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

}
