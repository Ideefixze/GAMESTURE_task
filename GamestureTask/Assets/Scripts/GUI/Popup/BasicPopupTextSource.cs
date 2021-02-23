using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPopupTextSource : MonoBehaviour, IPopupTextSource
{
    [SerializeField]
    [Multiline]
    private string DefaultText;
    public string GetPopupText()
    {
        return DefaultText;
    }
    
}
