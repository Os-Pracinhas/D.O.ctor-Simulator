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
        string nome = "Carlos Alberto";
        string idade = "58 anos";
        string sexo = "Masculino";
        string relato = "Teve diarreia e morreu de hemorragia interna";

        string respostaA = "A009";
        string respostaB = "A010";
        string respostaC = "A011";
        string respostaD = "A012";
        string respostaE = "A013";
        string respostaF = "A014";
        string tempoA = "5 Minutos";
        string tempoB = "5 Minutos";
        string tempoC = "5 Minutos";
        string tempoD = "5 Minutos";
        string tempoE = "5 Minutos";
        string tempoF = "5 Minutos";
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
