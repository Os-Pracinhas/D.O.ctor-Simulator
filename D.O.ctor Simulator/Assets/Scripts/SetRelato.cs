using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRelato : MonoBehaviour
{
    public GameObject relato;
    void Start()
    {
        string nome = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().caso.nome;
        string idade = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().caso.idade;
        string sexo = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().caso.sexo;
        string textRelato = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>().caso.relato;
        relato.transform.GetChild(2).gameObject.GetComponent<Text>().text = nome;
        relato.transform.GetChild(3).gameObject.GetComponent<Text>().text = idade;
        relato.transform.GetChild(4).gameObject.GetComponent<Text>().text = sexo;
        relato.transform.GetChild(5).gameObject.GetComponent<Text>().text = textRelato;
    }

}
