using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource musicSource;
    public AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip[] musicClips;
    public AudioClip[] sfxClips;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayMusic(int index)
    {
        if (index < 0 || index >= musicClips.Length)
            return;

        musicSource.clip = musicClips[index];
        musicSource.Play();
    }

    public void PlaySFX(int index)
    {
        if (index < 0 || index >= sfxClips.Length)
            return;

        sfxSource.PlayOneShot(sfxClips[index]);
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }

    public void StopSFX()
    {
        sfxSource.Stop();
    }
}
