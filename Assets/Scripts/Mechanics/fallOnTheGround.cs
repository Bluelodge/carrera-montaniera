using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class fallOnTheGround : MonoBehaviour
{
    //Variable nivel
    private string levelName;

    void OnTriggerEnter(Collider other)
    {
      //Condicional para trigger
      if(other.gameObject.tag == "Player")
      {
        print("El jugador cayó al suelo");
        //Obtiene nombre de la escena
        levelName = SceneManager.GetActiveScene().name;
        //Cargar nivel de acuerdo a la escena actual
        switch(levelName)
        {
          case "Level1": SceneManager.LoadScene("Scenes/Level1");
                         Debug.Log("Reinicio Nivel 1");
                         //Reinicia contador de puntos
                         playerPoints.arepitasCountLevel1 = 0;
          break;
          case "Level2": SceneManager.LoadScene("Scenes/Level2");
                         Debug.Log("Reinicio Nivel 2");
                         //Reinicia contador de puntos
                         playerPoints.arepitasCountLevel2 = 0;
          break;
        }
      }
    }
}
