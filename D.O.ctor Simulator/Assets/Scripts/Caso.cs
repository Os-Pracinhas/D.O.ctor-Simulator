using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

[System.Serializable]
public class Caso
{
    public int num;
    public string foto;
    public string nome;
    public string idade;
    public string sexo;
    public string relato;

    public Caso(string foto, int num, string nome, string idade, string sexo, string relato){
        this.foto = foto;
        this.num = num;
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.relato = relato;
    }
    public Caso(){}

    public int getNum(){
        return this.num;
    }
}