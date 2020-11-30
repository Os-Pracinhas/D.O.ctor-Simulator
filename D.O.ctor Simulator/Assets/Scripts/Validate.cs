using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validate : MonoBehaviour
{
    public void Valide(GameObject drop){
        InputField[] inputs = new InputField[6];
        string[] dr = new string[6];
        GameObject n = drop.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject;
        GameObject t = drop.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject;
        GameObject ip = drop.transform.GetChild(0).gameObject;
        
        for (int i = 0; i < 6; i++)
        {
            dr[i] = n.transform.GetChild(i).gameObject.GetComponent<Dropdown>().value+" "+t.transform.GetChild(i).gameObject.GetComponent<Dropdown>().options[t.transform.GetChild(i).gameObject.GetComponent<Dropdown>().value].text;
            inputs[i] = ip.transform.GetChild(i).gameObject.GetComponent<InputField>();
        }
        // Debug.Log(n);
    }
}
