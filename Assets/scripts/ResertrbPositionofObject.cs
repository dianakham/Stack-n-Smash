using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class ResertrbPositionofObject : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private Vector3 rbStartPosition;
    private Quaternion rbStartRotation;

    void Start()
    {
        UIbuttonHandler.OnUIResetButtonClicked += ResetRbPositiOnButtonClicked;

        rbStartPosition = rb.transform.localPosition;
        rbStartRotation = rb.transform.localRotation;
    }

    private void ResetRbPositiOnButtonClicked()
    {
        rb.isKinematic = true;

        rb.transform.localPosition = rbStartPosition;
        rb.transform.localRotation = rbStartRotation;

        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

    }

    private void OnDestroy()
    {
        UIbuttonHandler.OnUIResetButtonClicked -= ResetRbPositiOnButtonClicked;
    }
}
