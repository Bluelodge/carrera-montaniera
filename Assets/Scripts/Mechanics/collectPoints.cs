using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class collectPoints : MonoBehaviour
{
    //Variable arepitas
    private int valArepitas = 10;
    //Variable nivel
    private string levelName;

    void Start()
    {
      //Obtiene nombre de la escena
      levelName = SceneManager.GetActiveScene().name;
    }

    void OnTriggerEnter(Collider other)
    {
      if (other.gameObject.tag == "Player")
      {
        print("Se ha recolectado una arepita");
        //Destruye arepita actual
        Destroy(gameObject);
        //Llama variable del jugador y le pasa valor en cada nivel
        switch(levelName)
        {
          case "Level1": playerPoints.arepitasCountLevel1 += valArepitas;
                         Debug.Log("Arepitas acumuladas en Nivel 1: " + playerPoints.arepitasCountLevel1);
          break;
          case "Level2": playerPoints.arepitasCountLevel2 += valArepitas;
                         Debug.Log("Arepitas acumuladas en Nivel 2: " + playerPoints.arepitasCountLevel2);
          break;
        }
      }
    }
}
