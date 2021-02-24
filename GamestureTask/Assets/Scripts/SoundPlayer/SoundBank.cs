using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

/// <summary>
/// Basic class for handling data for SFX loaded by the game.
/// </summary>
public class Sound
{
    public bool Enabled;
    public AudioClip AudioClip;
}

/// <summary>
/// Contains all Sounds used in randomized play functionality and loads them from existing AudioClips.
/// </summary>
public class SoundBank : MonoBehaviour
{
    // Container for all Sounds used in randomized play sound functionality
    public List<Sound> Sounds { get; private set; }

    public List<AudioClip> AudioClips;

    private IOptionsDisplayer<SoundBank> optionsDisplayer;

    public void Start()
    {
        LoadUpSounds();
    }

    /// <summary>
    /// Used for initializing all sounds and creating all options for them.
    /// Reexecute this method to load up all sounds again.
    /// </summary>
    public void LoadUpSounds()
    {
        optionsDisplayer = GetComponent<IOptionsDisplayer<SoundBank>>();

        MakeSoundsFromClips();
        optionsDisplayer?.DisplayOptions(this);
    }

    /// <summary>
    /// Loads sounds from given clips and generates additional data for them.
    /// </summary>
    private void MakeSoundsFromClips()
    {
        Sounds = new List<Sound>();
        foreach (AudioClip clip in AudioClips)
        {
            Sound newSound = new Sound() { AudioClip = clip, Enabled = true }; //All sounds are enabled by default.
            Sounds.Add(newSound);
        }
    }
}
