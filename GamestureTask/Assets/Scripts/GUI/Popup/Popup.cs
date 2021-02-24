using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Base class for all Popup UI objects.
/// </summary>

[RequireComponent(typeof(Animator))]
public class Popup : MonoBehaviour
{

    //Close Button should not be changed
    [field:SerializeField]
    public Button CloseButton { get; private set; }

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        InitPopup();
    }

    /// <summary>
    /// Shows a popup.
    /// </summary>
    public void ShowPopup()
    {
        animator.SetBool("closed", false);
    }

    /// <summary>
    /// Adds all required functionality to the popup.
    /// </summary>
    private void InitPopup()
    {
        CloseButton.onClick.AddListener(() => animator.SetBool("closed", true));
    }
}
