using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelsCountdown : MonoBehaviour
{
    //Variable global
    public static bool start;
    //Variable tiempo actual
    private float currentTime;
    //Variable contador numérico
    private float timer = 4;
    //Variable de la animación
    private Animator animationCountdown;

    void Start()
    {
      //Obtener cuenta regresiva
      currentTime = timer;
      //Booleano falso
      start = false;
      //Obtiene el componente animation
      animationCountdown = GetComponent<Animator>();
    }

    void Update()
    {
      //Realizar cuenta regresiva
      currentTime -= 1 * Time.deltaTime;
      //Condicional para poner fin a contador y comenzar el nivel
      if (currentTime <= 0)
      {
        currentTime = 0;
        start = true;
      }
    }
}
