using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
//     public static AudioManager Instance;
//     public SoundControl[] musicSounds, sfxSounds;
//     public AudioSource musicSource, sfxSource;

//     private void Awake()
//     {
//         if (Instance == null) 
//         {
//             Instance = this;
//             DontDestroyOnLoad(gameObject);
//         }
//         else 
//         {
//             Destroy(gameObject);
//         }
//     }

//     private void Start()
//     {
//         PlayMusic("Theme"); // Added missing semicolon
//     }

//     public void PlayMusic(string name) 
//     {
//         SoundControl s = Array.Find(musicSounds, x => x.name == name);
//         if (s == null)
//         {
//             Debug.LogWarning("Music Sound Not Found: " + name);
//         }
//         else 
//         {
//             musicSource.clip = s.clip;
//             musicSource.Play();
//         }
//     }

//     public void PlaySFX(string name) 
//     {
//         SoundControl s = Array.Find(sfxSounds, x => x.name == name);
//         if (s == null) 
//         {
//             Debug.LogWarning("SFX Sound Not Found: " + name);
//         }
//         else 
//         {
//             sfxSource.PlayOneShot(s.clip); 
//         }
//     }

//     public void ToggleMusic()
//     {
//         sfxSource.mute = !sfxSource.mute;
//     }

//     public void MusicVolume(float volume)
//     {
//         musicSource.volume = volume;
//     }

//     public void SFXVolume(float volume)
//     {
//         sfxSource.volume = volume;
//     }
}


