using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para usar elementos UI
using UnityEngine.UI;

public class setPlayerName : MonoBehaviour
{
    //Varible texto nombre en Menú
    public Text textName;

    void Start()
    {
      //Mostrar nombre del jugador en pantalla Menú
      textName.text += getPlayerName.playerN.ToUpper();
      Debug.Log("Jugador: " + textName);
    }

}
