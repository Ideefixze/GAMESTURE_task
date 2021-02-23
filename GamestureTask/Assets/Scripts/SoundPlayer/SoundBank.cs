using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Sound
{
    public bool Enabled;
    public AudioClip AudioClip;
}

public class SoundBank : MonoBehaviour
{
    public List<Sound> Sounds { get; private set; }

    [SerializeField]
    private AudioClip[] audioClips;

    [SerializeField]
    private SoundBankOptions options;

    public void Start()
    {
        MakeSoundsFromClips();
        options.ShowSoundIncludeOptions(Sounds);
    }

    private void MakeSoundsFromClips()
    {
        Sounds = new List<Sound>();
        foreach (AudioClip clip in audioClips)
        {
            Sound newSound = new Sound() { AudioClip = clip, Enabled = true };
            Sounds.Add(newSound);
        }
    }
}
