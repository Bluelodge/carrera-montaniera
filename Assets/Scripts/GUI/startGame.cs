using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
  //Click en botón Jugar
  public void OnButtonClicked()
  {
    Debug.Log("Comienza partida en Nivel 1: ");
    //Carga escena
    SceneManager.LoadScene("Scenes/Level1");
    //Bloquear cursor a la pantalla del juego siendo invisible
    Cursor.lockState = CursorLockMode.Locked;
  }
}
