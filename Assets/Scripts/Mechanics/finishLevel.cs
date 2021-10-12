using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class finishLevel : MonoBehaviour
{
    //Variable nivel
    private string levelName;

    void Start()
    {
      //Obtiene nombre de la escena
      levelName = SceneManager.GetActiveScene().name;
    }

    void OnTriggerEnter(Collider other)
    {
      //Funciona solo si el trigger está activo
      if(finishActivate.finish == true)
      {
        if (other.gameObject.tag == "Player")
        {
          //Llama variable del jugador y le pasa valor en cada nivel
          switch(levelName)
          {
            case "Level1": Debug.Log("Finalizó nivel 1");
                           SceneManager.LoadScene("Scenes/WinLevel1");
                           //Bloquear cursor a la pantalla del juego siendo visible
                           Cursor.lockState = CursorLockMode.Confined;
            break;
            case "Level2": Debug.Log("Finalizó nivel 2");
                           SceneManager.LoadScene("Scenes/WinLevel2");
                           //Bloquear cursor a la pantalla del juego siendo visible
                           Cursor.lockState = CursorLockMode.Confined;
            break;
          }
        }
      }
    }
}
