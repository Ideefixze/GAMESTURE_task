using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Displays option for inclusion of sounds on given layout group.
/// </summary>
public class SoundBankIncludeOptionsDisplayer : MonoBehaviour, IOptionsDisplayer<SoundBank>
{
    [SerializeField]
    private GameObject includePanel; //Spawned object

    [SerializeField]
    private LayoutGroup optionsTarget; //LayoutGroup that will have includePanels as children.

    private List<SoundInclude> includePanels;

    //Validate if IncludePanel has required components.
    private void OnValidate()
    {
        if (includePanel.GetComponent<SoundInclude>() == null)
            Debug.LogError("IncludePanel requires SoundInclude component!");
    }

    /// <summary>
    /// Displays option for SoundBank Sounds to be included in randomization.
    /// </summary>
    /// <param name="sounds">SoundBank to be handled in options</param>
    public void DisplayOptions(SoundBank soundBank)
    {
        List<Sound> sounds = soundBank.Sounds;

        //Destroy previous panels if showing include options is called more than once
        if (includePanels != null)
            foreach (SoundInclude include in includePanels) Destroy(include.gameObject);

        //Fill in include panels and set them up 
        includePanels = new List<SoundInclude>();
        foreach(Sound s in sounds)
        {
            GameObject panel = Instantiate(includePanel, optionsTarget.transform);
            SoundInclude soundInclude = panel.GetComponent<SoundInclude>();
            soundInclude.SetUpToSound(s);

            //Adding SoundIncludes to the list, so it can be easily operated later on (destroying, enabling all at once etc.)
            includePanels.Add(soundInclude); 
        }
    }

}
