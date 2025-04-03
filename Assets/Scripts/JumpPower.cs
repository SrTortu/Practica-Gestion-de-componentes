using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPower : PowerBase
{
    #region Fields

    private float _jumpPower;
    private Rigidbody _rigidbody;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _jumpPower = 20;
    }

    #endregion

    #region Private Methods

    private void Jump()
    {
        _rigidbody.AddForce(transform.up * _jumpPower, ForceMode.Impulse);
    }

    #endregion

    #region Public Methods

    public override void ActivatePower()
    {
        Jump();
    }

    #endregion
}