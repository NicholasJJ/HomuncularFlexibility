using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetShoulders : MonoBehaviour
{
    [SerializeField] XRBaseController input;

    // Update is called once per frame
    void Update()
    {
        if (input.uiPressInteractionState.activatedThisFrame)
        {
            transform.position = input.transform.position;
        }
    }
}
