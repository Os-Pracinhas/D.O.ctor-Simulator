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
        string nome = "Maria Luiza";
        string idade = "48 anos";
        string sexo = "Feminino";
        string relato = "Maria Luiza de Oliveira de 48 anos chegou no hospital alertando sobre uma vermelhidão e 2 caroços perto das axilas. Ela tinha histórico de problemas de obesidade por 10 anos e Hipertensão arterial primaria por 8 anos. Dito isso, o hospital imediatamente fez a mamografia e em sequência a ultrassonografia, após isso automaticamente começou o tratamento para o possível câncer de mama. Dessa forma, em 2 meses de medicamento após o diagnóstico, um dos caroços foi destruído, porém, o outro se espalhou para o pulmão provocando uma parada respiratória. Chegando ao óbito por Caquexia 4 dias depois.";

        string respostaA = "R64";
        string respostaB = "J940";
        string respostaC = "C781";
        string respostaD = "C506";
        string respostaE = "E660";
        string respostaF = "I10";
        string tempoA = "4 Dias";
        string tempoB = "10 Dias";
        string tempoC = "3 Dias";
        string tempoD = "2 Meses";
        string tempoE = "10 Anos";
        string tempoF = "8 Anos";
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
