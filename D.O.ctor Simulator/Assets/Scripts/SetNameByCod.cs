using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetNameByCod : MonoBehaviour
{
    public TextAsset csv;
    CID_10 cid10 = new CID_10();
    public InputField cod;
    public InputField nome;
    // Start is called before the first frame update
    void Start()
    {
        cod.onEndEdit.AddListener(delegate { SetName(cod);});
    }

    public void SetName(InputField codigo)
    {
        cid10.Load(csv);
        nome.text = cid10.Find_SUBCAT(codigo.text).DESCRICAO;
    }
}
