using UnityEngine;
//Dependencia
using UnityEngine.Audio;

[System.Serializable]
public class Sound
{
    //Variables
    public string name;
    public AudioClip audioClip;
    public AudioSource audioSource;
    //Variables con sliders
    [Range(0, 1)] public float volume;
    [Range(0, 1)] public float pitch;
    public bool loop;

    
}
