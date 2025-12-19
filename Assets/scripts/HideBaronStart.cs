using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideBaronStart : MonoBehaviour
{
    [SerializeField] private Canvas ARMagicBar;
    void Start()
    {
        UIbuttonHandler.OnUIStartButtonClicked += OnUIStartButtonClicked;
        UIbuttonHandler.OnUIResetButtonClicked += OnUIResetButtonClicked;

    }

    private void OnUIStartButtonClicked()
    {
        ARMagicBar.enabled = false;
    }

    private void OnUIResetButtonClicked()
    {
        ARMagicBar.enabled = true;
    }
}
