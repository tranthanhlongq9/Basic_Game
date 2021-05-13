using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrimMoments : MonoBehaviour
{
    #region Variable.
    [Header("Grim Animator")]
    [SerializeField] private GrimAnimator grimAnimator;

    [SerializeField]private float speed = 2.0f;
    private float sensivity = 1.0f;
    private float damping = 0.5f;

    private Vector2 V2Move = Vector2.zero;
    private Vector2 V2Mouse = Vector2.zero;

    private Vector3 V3DirectionMove = Vector3.zero;
    private Vector3 V3CurrentRotations = Vector3.zero;
    private Vector3 V3DirectionRotation = Vector3.zero;

    #endregion

    #region GetFunctions.
    public float GetSensivity()
    {
        return sensivity;
    }

    #endregion

    #region Functions.
    public void Update()
    {
        Turning();
        Moving();
    }

    private void Turning()
    {
        V2Mouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        V3CurrentRotations.x = Mathf.Lerp(V3CurrentRotations.x, V2Mouse.x, 1.0f / damping);
        V3DirectionRotation = Vector3.up * V3CurrentRotations.x * sensivity;
        transform.Rotate(V3DirectionRotation);
    }
    private void Moving()
    {
        V2Move = new Vector2(grimAnimator.GetVertical() * speed, grimAnimator.GetHorizontal()* speed);
        V3DirectionMove = transform.forward * V2Move.x * Time.deltaTime + transform.right * V2Move.y * Time.deltaTime;
        transform.position += V3DirectionMove;
    }

    
    #endregion
}
