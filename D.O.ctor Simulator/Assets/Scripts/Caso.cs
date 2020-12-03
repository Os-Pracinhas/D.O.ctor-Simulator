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

    public string respostaA;
    public string respostaB;
    public string respostaC;
    public string respostaD;
    public string respostaE;
    public string respostaF;
    public string tempoA;
    public string tempoB;
    public string tempoC;
    public string tempoD;
    public string tempoE;
    public string tempoF;

    public Caso(string foto, int num, string nome, string idade, string sexo, string relato, string respostaA, string respostaB, string respostaC, string respostaD, string respostaE, string respostaF, string tempoA, string tempoB, string tempoC, string tempoD, string tempoE, string tempoF){
        this.foto = foto;
        this.num = num;
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
        this.relato = relato;
        this.respostaA = respostaA;
        this.respostaB = respostaB;
        this.respostaC = respostaC;
        this.respostaD = respostaD;
        this.respostaE = respostaE;
        this.respostaF = respostaF;
        this.tempoA = tempoA;
        this.tempoB = tempoB;
        this.tempoC = tempoC;
        this.tempoD = tempoD;
        this.tempoE = tempoE;
        this.tempoF = tempoF;
    }
    public Caso(){}

    public int getNum(){
        return this.num;
    }
}