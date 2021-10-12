using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;
//Dependencia para usar elementos UI
using UnityEngine.UI;

public class playerPoints : MonoBehaviour
{
    //Variables globales puntaje
    public static int arepitasCountLevel1;
    public static int arepitasCountLevel2;
    //Variable para texto en pantalla de niveles
    public Text arepitasTexto;
    //Variable nivel
    private string levelName;
    //Variable para texto en pantalla final
    public Text totalArepitas1Texto;
    public Text totalArepitas2Texto;

    void Start()
    {
      //Obtiene nombre de la escena
      levelName = SceneManager.GetActiveScene().name;
    }

    void Update()
    {
      //Puntos en cada nivel
      switch(levelName)
      {
        case "Level1": arepitasTexto.text = arepitasCountLevel1.ToString();
        break;
        case "Level2": arepitasTexto.text = arepitasCountLevel2.ToString();
        break;
        case "Final": totalArepitas1Texto.text = arepitasCountLevel1.ToString();
                      totalArepitas2Texto.text = arepitasCountLevel2.ToString();
                      Debug.Log("Total nivel 1: " + arepitasCountLevel1);
                      Debug.Log("Total nivel 2: " + arepitasCountLevel2);
        break;
      }
    }
}
