using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Dependencia para cargar las escenas
using UnityEngine.SceneManagement;

public class enemyMovement : MonoBehaviour
{
    //Variable del jugador
    public Transform _targetPlayer;
    //Variable para el componente
    private Rigidbody _rigidbodyEnemy;
    //Variable privada para velocidad
    [SerializeField] float _speedEnemy;
    //Variable vector posición
    Vector3 initialPosition;
    //Variable nivel
    private string levelName;

    void Start()
    {
      //Obtiene el componente
      _rigidbodyEnemy = this.GetComponent<Rigidbody>();
      //Obtiene posición inicial
      initialPosition = transform.position;
      print("Posición inicial " + initialPosition);
    }

    void Update()
    {
      //Condicional para empezar la partida
      if (levelsCountdown.start == true)
      {
        //Persigue el jugador
        Vector3 direction = (_targetPlayer.position - transform.position).normalized;
        transform.position += direction * _speedEnemy * Time.deltaTime;
      }
    }

    void OnTriggerEnter(Collider player)
    {
      //Condicional para trigger
      if(player.gameObject.tag == "Player")
      {
        Debug.Log("El enemigo atrapó al jugador");
        //Obtiene nombre de la escena
        levelName = SceneManager.GetActiveScene().name;
        Debug.Log("Nivel actual: " + levelName);
        //Cargar nivel de acuerdo a la escena actual
        switch(levelName)
        {
          case "Level1": SceneManager.LoadScene("Scenes/Level1");
                         Debug.Log("Reinicio Nivel 1");
                         //Reinicia contador de puntos
                         playerPoints.arepitasCountLevel1 = 0;
          break;
          case "Level2": SceneManager.LoadScene("Scenes/Level2");
                         Debug.Log("Reinicio Nivel 2");
                         //Reinicia contador de puntos
                         playerPoints.arepitasCountLevel2 = 0;
          break;
        }
      }
    }

/*
    void OnDrawGizmos()
    {
      Gizmos.DrawLine(_targetPlayer.position, transform.position);
    }*/
}
