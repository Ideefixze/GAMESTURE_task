using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// GUI component that sets up a Sound to be enabled in randomization or not based on Toggle.
/// </summary>
public class SoundInclude : MonoBehaviour
{
    public Toggle Toggle;
    public TMP_Text Text;

    /// <summary>
    /// Sets up toggle action for enabling/disabling a sound and sets up a Text.
    /// </summary>
    /// <param name="sound">Sound to be set up to</param>
    public void SetUpToSound(Sound sound)
    {
        Toggle.onValueChanged.AddListener(v => sound.Enabled = v);
        Text.text = $"Include {sound.AudioClip.name}";
    }
}
