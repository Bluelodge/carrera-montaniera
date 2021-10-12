using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //Variable para el componente
    private Rigidbody _rigidbodyPlayer;
    //Variable animación
    public Animator animPlayer;
    //Variable para activar moivimiento
    private bool movingPlayer;
    //Variables de velocidad movimiento y rotación
    private float playerSpeed;
    private float rotationSpeed;
    private float rotationTime;
    //Cámara
    public Transform cam;

    void Start()
    {
      //Obtiene el componente
      _rigidbodyPlayer = GetComponent<Rigidbody>();
      playerSpeed = 30f;
      //Componente de la animación
      animPlayer = GetComponent<Animator>();
    }

    void Update()
    {
      //Condicional para empezar la partida
      if (levelsCountdown.start == true)
      {
        //Vector movimiento
        Vector3 moveXY = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        //Rota solo cuando hay movimiento
        if(moveXY.magnitude >= 0.1f)
        {
          float angleDirection = Mathf.Atan2(moveXY.x, moveXY.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
          //Dirección de movimiento
          Vector3 moveDirection = Quaternion.Euler(0f, angleDirection, 0f) * Vector3.forward;
          //Cambio de movimiento
          _rigidbodyPlayer.MovePosition(transform.position + moveDirection.normalized * Time.deltaTime * playerSpeed);
          //El personaje se está moviendo
          movingPlayer = true;
        }
        else
        {
          //El personaje no se está moviendo
          movingPlayer = false;
        }

        //Activar y desactivar animación
        animPlayer.SetBool("moving", movingPlayer);
      }
    }
}
