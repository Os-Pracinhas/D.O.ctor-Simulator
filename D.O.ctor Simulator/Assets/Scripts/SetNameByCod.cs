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
        // cod.onEndEdit.AddListener(delegate { SetName(cod);});

        cid10.Load(csv);
        foreach(CID_10.Row r in cid10.FindAll_SUBCAT("A0")){
            Debug.Log(r.SUBCAT);
        }
    }

    public void SetName(InputField codigo)
    {
        cid10.Load(csv);
        nome.text = cid10.Find_SUBCAT(codigo.text).DESCRICAO;
    }

    public void SetNameOrCod(){
        cid10.Load(csv);
        int aux = 0;
        


        // n = GameObject.Instantiate(but, content.transform, false) as GameObject;
        // n.transform.position = new Vector2(n.transform.position.x, n.transform.position.y-(multi*cont++));
        // n.transform.localScale = new Vector3(1,1,1);
        // n.GetComponentInChildren<Text>().text = pla.name;
        // n.GetComponent<Button>().onClick.AddListener(delegate {SearchPlayer(pla.name);});
        // nome.text = 
    }
}
