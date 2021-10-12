using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class showFinal : MonoBehaviour
{
    //Click en botón Final
    public void OnButtonClicked()
    {
        SceneManager.LoadScene("Scenes/Final");
        Debug.Log("Escena final cargada");
    }

}
