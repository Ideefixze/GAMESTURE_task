using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Base class for all Popup UI objects.
/// </summary>
public class Popup : MonoBehaviour
{
    public TMP_Text MainText;

    //Close Button should not be changed
    [field:SerializeField]
    public Button CloseButton { get; private set; }

    void Start()
    {
        InitPopup();
    }

    void InitPopup()
    {
        //Close Button functionality initialization
        CloseButton.onClick.AddListener(() => Destroy(gameObject));
    }
}
