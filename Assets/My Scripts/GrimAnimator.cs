using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimAnimator : MonoBehaviour
{
    #region Variable.
    [Header("Animator")]
    [SerializeField] private Animator grimAnimator;

    private float vertical = 0.0f;
    private float horizontal = 0.0f;

    private bool isPistol = false;
    private bool isSprint = false;
    private bool isAiming = false;
    private bool isFiring = false;
    #endregion

    #region Get Functions.
    public float GetVertical()
    {
        return vertical;
    }
    public float GetHorizontal()
    {
        return horizontal;
    }
    public bool GetIsPistol()
    {
        return isPistol;
    }
    public bool GetIsSprint()
    {
        return isSprint;
    }
    public bool GetIsAiming()
    {
        return isAiming;
    }
    public bool GetIsFiring()
    {
        return isFiring;
    }

    #endregion

    #region Functions.
    private void Update()
    {
        Moving();
    }

    private void Moving()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        

        grimAnimator.SetFloat("Vertical", vertical);
        grimAnimator.SetFloat("Horizontal", horizontal);
    }
    #endregion
}
