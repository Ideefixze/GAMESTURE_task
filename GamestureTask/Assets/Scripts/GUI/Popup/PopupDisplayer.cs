using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Displays a popup in the middle of the screen by instantiating a displayerPopup object.
/// </summary>

[RequireComponent(typeof(IPopupTextSource))]
public class PopupDisplayer : MonoBehaviour
{
    [SerializeField]
    protected GameObject displayedPopup;

    private IPopupTextSource popupTextSource;

    public void Start()
    {
        popupTextSource = GetComponent<IPopupTextSource>();
    }

    public void DisplayPopup()
    {
        Popup popup = Instantiate(displayedPopup)?.GetComponent<Popup>();

        if (popup == null) throw new MissingComponentException("Failed to display Popup. Check if DisplayedPopup has a Popup component.");

        //Set up Popup position and parent
        popup.GetComponent<RectTransform>().position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        popup.transform.parent = FindObjectOfType<Canvas>().transform;

        //Set up Popup text
        popup.MainText.text = popupTextSource.GetPopupText();
    }
}
