using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leaveGame : MonoBehaviour
{
    //Click en botón Salir
    public void OnButtonClicked()
    {
      Debug.Log("Has salido del juego");
      //Sale de la app
      Application.Quit();
    }
}
