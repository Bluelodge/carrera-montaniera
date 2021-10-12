using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    //Usa la clase Sound
    public Sound[] sounds;

    void Awake()
    {
      //Por cada elemento se añade el audio source
      foreach(Sound sound in sounds)
      {
        //Añade componente
        AudioSource s = gameObject.AddComponent<AudioSource>();
        //Toma elementos de la clase
        s.clip = sound.audioClip;
        s.volume = sound.volume;
        s.pitch = sound.pitch;
        s.loop = sound.loop;
        sound.audioSource = s;
      }
    }

    void Start()
    {
      //Los sonidos que se reprduzcan al inicio
      //Play("bakcground");
    }

    //Método
    void Play(string name)
    {
      foreach(Sound sound in sounds)
      {
        if(sound.name == name)
        {
          sound.audioSource.Play();
        }
      }
    }
}
