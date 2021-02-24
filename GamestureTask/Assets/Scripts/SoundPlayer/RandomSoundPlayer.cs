using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

/// <summary>
/// RandomSoundPlayer component provides a method that plays a random enabled sound from a SoundBank attached to this gameObject.
/// </summary>
public class RandomSoundPlayer : MonoBehaviour
{
    private SoundBank soundBank;
    private AudioSource audioSource;

    public void Start()
    {
        soundBank = GetComponent<SoundBank>();
        audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Randomizes a sound from available list of sounds and plays it on the audioSource.
    /// If no sound is enabled, do nothing.
    /// </summary>
    public void PlayRandomSound()
    {
        List<Sound> sounds = soundBank.Sounds.Where(s => s.Enabled).ToList();
        if(sounds.Count>0)
            audioSource.PlayOneShot(sounds[Random.Range(0, sounds.Count)].AudioClip);
    }
}
