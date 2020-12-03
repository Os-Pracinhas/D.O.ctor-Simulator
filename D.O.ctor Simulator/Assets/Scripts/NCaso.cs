using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;
using System;
using System.Runtime.Serialization.Formatters.Binary;

public class NCaso : MonoBehaviour
{
    private string arquivo;

    public void SaveCaso(){
        List<Caso> casos = LoadCaso();
        int count = casos.Count();
        Caso caso;
        string foto = Application.dataPath+"/casos/foto/pele.jpg";
        int numCaso = count;
        string nome = "Arthur Costa da Silva";
        string idade = "34 Anos";
        string sexo = "Masculino";
        string relato = "O paciente chegou no hospital apresentando o quadro de febre alta, gripe, dores musculares e vômito a 5 dias, com todos os sintomas. Depois de um exame, fora descoberto que havia hemorragia interna. Mesmo que os medicos tivessem se apressando para a operação, Arthur morreu 30 minutos depois da chegada";

        string respostaA = "R580";
        string respostaB = "A910";
        string respostaC = "";
        string respostaD = "";
        string respostaE = "J118";
        string respostaF = "";
        string tempoA = "30 Minutos";
        string tempoB = "5 Dias";
        string tempoC = "";
        string tempoD = "";
        string tempoE = "5 Dias";
        string tempoF = "";
        if (count == 0)
        {
            caso = new Caso(foto, 1, nome, idade, sexo, relato, respostaA, respostaB, respostaC, respostaD, respostaE, respostaF, tempoA, tempoB, tempoC, tempoD, tempoE, tempoF);
        }
        else
        {
            caso = new Caso(foto, numCaso, nome, idade, sexo, relato, respostaA, respostaB, respostaC, respostaD, respostaE, respostaF, tempoA, tempoB, tempoC, tempoD, tempoE, tempoF);
        }

        casos.Add(caso);

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.dataPath+"/casos.fun";
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, casos);
        stream.Close();
    }
    public void GetTotal(){
        List<Caso> casos = LoadCaso();
        Debug.Log(casos.Count());

    }
    public List<Caso> LoadCaso(){
        BinaryFormatter formatter = new BinaryFormatter();
        List<Caso> data;
        string path = Application.dataPath+"/casos.fun";
        if (File.Exists(path))
        {
            FileStream stream = new FileStream(path, FileMode.Open);

            data = formatter.Deserialize(stream) as List<Caso>;
            stream.Close();
            return data;
        }
        else
        {
            data = new List<Caso>();
            FileStream stream = new FileStream(path, FileMode.Create);
            formatter.Serialize(stream, data);
            stream.Close();
            return data;
        }
    }
}
