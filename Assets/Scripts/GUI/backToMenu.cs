using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
    //Click en botón Atrás
    public void OnButtonClicked()
    {
      //Carga escena
      SceneManager.LoadScene("Scenes/Menu");
      Debug.Log("Menú cargado");
    }
}
