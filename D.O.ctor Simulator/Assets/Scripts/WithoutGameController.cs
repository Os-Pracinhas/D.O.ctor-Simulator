using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WithoutGameController : MonoBehaviour
{
    // Start is called before the first frame update
    Scene sce;
    void Start(){
    	sce = SceneManager.GetActiveScene();
    }
    public void toLoadScene(GameObject content){
    	(sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(1).gameObject.transform.GetChild(0).gameObject.SetActive(false);
        (sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(1).gameObject.transform.GetChild(1).gameObject.SetActive(true);

        FindObjectOfType<Player>().LoadPlayers(content);
    }
    public void LoadDoScene(int numCaso){
        FindObjectOfType<GameController>().LoadGameDoScene(numCaso);
    }

    public void SavePlayer(Text n){
        FindObjectOfType<Player>().SavePlayer(n);
    }

    public void LoadNiveisPlayer()
    {
        Player player = FindObjectOfType<Player>();
        // FindObjectOfType<GameController>().SetSelecionarNivel(pla);

        sce = SceneManager.GetActiveScene();
        GameObject pageLoadLevel = (sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
        Debug.Log(player);
        pageLoadLevel.SetActive(true);
        (sce.GetRootGameObjects() as GameObject[])[2].gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject.SetActive(false);
        if(!player.caso2){
            pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(1).gameObject.SetActive(false);
            pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.SetActive(false);
        }
        if(!player.caso3)pageLoadLevel.transform.GetChild(2).gameObject.transform.GetChild(2).gameObject.SetActive(false);
    }
}
