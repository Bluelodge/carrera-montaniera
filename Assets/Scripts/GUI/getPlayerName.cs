using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class getPlayerName : MonoBehaviour
{
    //Variable global nombre del jugador
    public static string playerN;

    //Obtener nombre del jugador en input
    public void ReadPlayerName( string name)
    {
      playerN = name;
      Debug.Log("Nombre jugador: " + playerN);
    }

    //Click en botón Ingresar
    public void OnButtonClicked()
    {
      Debug.Log("Nombre del jugador: ");
      //Carga escena
      SceneManager.LoadScene("Scenes/Menu");
    }
}
