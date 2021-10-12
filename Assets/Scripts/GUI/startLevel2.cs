using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class startLevel2 : MonoBehaviour
{
    //Click en botón Siguiente
    public void OnButtonClicked()
    {
      //Carga escena
      SceneManager.LoadScene("Scenes/Level2");
      Debug.Log("Comienza Nivel 2");
      //Bloquear cursor a la pantalla del juego siendo invisible
      Cursor.lockState = CursorLockMode.Locked;
    }
}
