using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validate : MonoBehaviour
{
    public GameObject telaVitoria;
    public GameObject telaDerrota;
    public void Valide(GameObject drop){
        InputField[] inputs = new InputField[6];
        string[] dr = new string[6];
        GameObject n = drop.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        GameObject t = drop.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject;
        GameObject ip = drop.transform.GetChild(0).gameObject;
        
        for (int i = 0; i < 6; i++)
        {
            dr[i] = (n.transform.GetChild(i).gameObject.GetComponent<Dropdown>().value + 1) +" "+t.transform.GetChild(i).gameObject.GetComponent<Dropdown>().options[t.transform.GetChild(i).gameObject.GetComponent<Dropdown>().value].text;
            inputs[i] = ip.transform.GetChild(i).gameObject.GetComponent<InputField>();
        }
        Debug.Log(dr[0]);
        GameController gC = FindObjectOfType<GameController>();
        if (gC.caso.respostaA == inputs[0].text && gC.caso.respostaB == inputs[1].text && gC.caso.respostaC == inputs[2].text && gC.caso.respostaD == inputs[3].text && ((gC.caso.respostaE == inputs[4].text && gC.caso.respostaF == inputs[5].text) || (gC.caso.respostaE == inputs[5].text && gC.caso.respostaF == inputs[4].text)) && gC.caso.tempoA == dr[0] && gC.caso.tempoB == dr[1] && gC.caso.tempoC == dr[2] && gC.caso.tempoD == dr[3] && ((gC.caso.tempoE == dr[4] && gC.caso.tempoF == dr[5]) || (gC.caso.tempoE == dr[5] && gC.caso.tempoF == dr[4])))
        {
            telaVitoria.SetActive(true);
        }
        else
        {
            telaDerrota.SetActive(true);
        }
    }
}
