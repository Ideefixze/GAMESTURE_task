using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundBankOptions : MonoBehaviour
{
    [SerializeField]
    private GameObject includePanel;

    private List<SoundInclude> includePanels;
    public void ShowSoundIncludeOptions(List<Sound> sounds)
    {
        //Destroy previous panels if showing include options is called more than once
        if (includePanels != null)
            foreach (SoundInclude include in includePanels) Destroy(include);

        includePanels = new List<SoundInclude>();
        foreach(Sound s in sounds)
        {
            GameObject panel = Instantiate(includePanel, transform);
            SoundInclude soundInclude = panel.GetComponent<SoundInclude>();
            soundInclude.SetUpToSound(s);
        }
    }
}
