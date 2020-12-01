using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player instance = null;

    public bool caso1 = true;
    public bool caso2 = false;
    public bool caso3 = false;
    public string name = null;
    
    public GameObject but;

    void Start(){
        if (instance == null) { instance = this; }
        else if (instance != this) { Destroy(gameObject); }
        DontDestroyOnLoad(gameObject);
    }


    public void SavePlayer(Text n){
        name = n.text;
        SaveSystem.SavePlayer(this);
        FindObjectOfType<GameController>().LoadGameDoScene(1);
    }

    public void LoadPlayers(GameObject content){
        PlayerData[] data = SaveSystem.LoadPlayers();
        GameObject n;
        int multi = 30;
        int cont = 0;
        foreach (PlayerData pla in data)
        {
            n = GameObject.Instantiate(but, content.transform, false) as GameObject;
            n.transform.position = new Vector2(n.transform.position.x, n.transform.position.y-(multi*cont++));
            n.transform.localScale = new Vector3(1,1,1);
            n.GetComponentInChildren<Text>().text = pla.name;
            n.GetComponent<Button>().onClick.AddListener(delegate {SearchPlayer(pla.name);});
        }
            
    }

    public void SearchPlayer(string n){
        PlayerData pla = SaveSystem.Search(n);
        // for (int i = 0; i < fases.Length; i++)
        // {
        //     fases[i] = pla.fases[i];
        // }
        caso1 = pla.caso1;
        caso2 = pla.caso2;
        caso3 = pla.caso3;
        name = n;
        FindObjectOfType<GameController>().SetSelecionarNivel(pla);
    }
}
