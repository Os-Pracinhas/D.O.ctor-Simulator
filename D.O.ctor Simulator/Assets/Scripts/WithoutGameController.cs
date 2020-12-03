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
    public void ExitGame()
    {
        Application.Quit();
    }
}
