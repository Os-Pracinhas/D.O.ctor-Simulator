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
    public Caso LoadCaso(int i){
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath+"/casos/caso"+(i+1)+".fun";
        FileStream stream = new FileStream(path, FileMode.Open);

        Caso data = formatter.Deserialize(stream) as Caso;
        
        stream.Close();
        return data;
    }

    public void SaveCaso(){
        Caso c;
        for (int i = 0; i < 3; i++)
        {
            c = new Caso(Application.persistentDataPath+"/fotos/pele.jpg", (i+1), "Carlos Alberto", "58 anos", "Masculino", "Teve diarreia e morreu de hemorragia interna");
            BinaryFormatter formatter = new BinaryFormatter();
            string path = Application.persistentDataPath+"/casos/caso"+(i+1)+".fun";
            FileStream stream = new FileStream(path, FileMode.Create);

            
            formatter.Serialize(stream, c);
            stream.Close();
        }
        
    }
}
