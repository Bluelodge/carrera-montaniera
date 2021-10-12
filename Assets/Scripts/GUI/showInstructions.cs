using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class showInstructions : MonoBehaviour
{
    //Click en botón Cómo Jugar
    public void OnButtonClicked()
    {
      //Carga escena
      SceneManager.LoadScene("Scenes/HowToPlay");
      Debug.Log("Instrucciones cargadas");
    }
}
