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

    public void ShowPopup()
    {
        animator.SetBool("closed", false);
    }

    private void InitPopup()
    {
        //Close Button functionality set up
        CloseButton.onClick.AddListener(() => animator.SetBool("closed", true));
    }
}
