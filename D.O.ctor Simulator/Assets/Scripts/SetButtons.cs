// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class SetButtons : MonoBehaviour
// {
//     GameObject[] obj;
//     public GameObject OpenWindowNameDr;
//     public GameObject pageHome;
//     public GameObject pageLoad;
//     public GameObject pageLoadLevel;
//     public GameObject content;

//     GameObject gameController;
//     // Start is called before the first frame update
//     void Start()
//     {
//         gameController = GameObject.FindGameObjectWithTag("GameController");
//         gameController.GetComponent<GameController>().pageHome = pageHome;
//         gameController.GetComponent<GameController>().pageLoad = pageLoad;
//         gameController.GetComponent<GameController>().pageLoadLevel = pageLoadLevel;
//         gameController.GetComponent<GameController>().OpenWindowNameDr = OpenWindowNameDr;




//         obj = GameObject.FindGameObjectsWithTag("ButtonsHome");
//         obj[0].GetComponent<Button>().onClick.AddListener(delegate { gameController.GetComponent<GameController>().SetNewMed(); });
//         obj[1].GetComponent<Button>().onClick.AddListener(delegate { gameController.GetComponent<GameController>().GetMed(content); });
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
