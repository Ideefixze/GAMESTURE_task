using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SoundInclude : MonoBehaviour
{
    public Toggle Toggle;
    public TMP_Text Text;

    public void SetUpToSound(Sound s)
    {
        Toggle.onValueChanged.AddListener(v => s.Enabled = v);
        Text.text = $"Include {s.AudioClip.name}";
    }
}
