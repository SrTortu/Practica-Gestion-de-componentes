using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveInput : MonoBehaviour
{
    #region Fields

    [SerializeField] private float _playerSpeed;

    private Vector3 _movementVector;
    private Rigidbody _playerRigidbody;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        _movementVector = new Vector3(moveX, 0, moveZ).normalized;
    }

    private void FixedUpdate()
    {
        _playerRigidbody.AddForce(_movementVector * _playerSpeed, ForceMode.Force);
    }

    #endregion
}