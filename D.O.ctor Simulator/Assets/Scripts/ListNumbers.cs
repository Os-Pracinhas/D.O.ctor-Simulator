using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListNumbers : MonoBehaviour
{
    public Dropdown numbers;
    public Dropdown tempo;

    void Start()
    {
        tempo.options.Clear();
        numbers.options.Clear();

        CallMetoth();

        List<string> itens = new List<string>();
        itens.Add("Segundos");
        itens.Add("Minutos");
        itens.Add("Horas");
        itens.Add("Dias");
        itens.Add("Meses");
        itens.Add("Anos");

        foreach (var item in itens)
        {
            tempo.options.Add(new Dropdown.OptionData() { text = item });
        }

        tempo.onValueChanged.AddListener(delegate { ChangedNumbers(tempo); });
    }

    void CallMetoth()
    {
        List<string> itens = new List<string>();
        itens = SelectedIndex(0);
        numbers.options.Clear();
        foreach (var item in itens)
        {
            numbers.options.Add(new Dropdown.OptionData() { text = item });
        } 
    }

    void ChangedNumbers(Dropdown dropdown)
    {
        List<string> itens = new List<string>();
        itens = SelectedIndex(dropdown.value);
        numbers.options.Clear();
        foreach (var item in itens)
        {
            numbers.options.Add(new Dropdown.OptionData() { text = item });
        }
    }

    List<string> SelectedIndex(int index)
    {
        List<string> itens = new List<string>();
        if (index == 0)
        {
            for (int i = 1; i <= 59; i++)
            {
            itens.Add(i.ToString());
            }
        }
        if (index == 1)
        {
            for (int i = 1; i <= 59; i++)
            {
            itens.Add(i.ToString());
            }
        }
        if (index == 2)
        {
            for (int i = 1; i <= 24; i++)
            {
            itens.Add(i.ToString());
            }
        }
        if (index == 3)
        {
            for (int i = 1; i <= 31; i++)
            {
            itens.Add(i.ToString());
            }
        }
        if (index == 4)
        {
            for (int i = 1; i <= 12; i++)
            {
            itens.Add(i.ToString());
            }
        }
        if (index == 5)
        {
            for (int i = 1; i <= 150; i++)
            {
            itens.Add(i.ToString());
            }
        }

        return itens;
    }
}
