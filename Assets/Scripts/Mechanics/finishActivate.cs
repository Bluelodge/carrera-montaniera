using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishActivate : MonoBehaviour
{
    //Variable global
    public static bool finish;

    void Start()
    {
      //Booleano falso
      finish = false;
    }

    void OnTriggerEnter(Collider other)
    {
      //Activa el trigger de la meta
      if(other.gameObject.tag == "Player")
      {
        finish = true;
      }      
    }
}
