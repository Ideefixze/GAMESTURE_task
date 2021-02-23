using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class RandomSoundPlayer : MonoBehaviour
{
    private SoundBank soundBank;
    private AudioSource audioSource;

    public void Start()
    {
        soundBank = GetComponent<SoundBank>();
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayRandomSound()
    {
        List<Sound> sounds = soundBank.Sounds.Where(s => s.Enabled).ToList();
        if(sounds.Count>0)
            audioSource.PlayOneShot(sounds[Random.Range(0, sounds.Count)].AudioClip);
    }
}
