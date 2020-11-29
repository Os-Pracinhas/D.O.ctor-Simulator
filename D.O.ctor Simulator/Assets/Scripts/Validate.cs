using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Validate : MonoBehaviour
{
    public void Valide(GameObject drop){
        Dropdown[] numbers;
        Dropdown[] time;
        Object n;
        Object t;

        n = drop.transform.GetChild(0).gameObject.transform.GetChild(0);
        t = drop.transform.GetChild(1).transform.GetComponent<Object>();

        Debug.Log(n);
        Debug.Log(t);
    }
}
