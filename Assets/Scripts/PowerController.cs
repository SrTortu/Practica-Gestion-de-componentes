using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerController : MonoBehaviour
{
    #region Fields

    private PowerBase _currentPower;

    #endregion

    #region Unity Callbacks

    void Update()
    {
        if (_currentPower != null)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _currentPower.ActivatePower();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (TryGetComponent(out _currentPower))
        {
            Destroy(_currentPower);
        }

        if (other.CompareTag("JumpZone"))
            _currentPower = gameObject.AddComponent<JumpPower>();

        if (other.CompareTag("ShootZone"))
            _currentPower = gameObject.AddComponent<ShootPower>();
    }

    #endregion
}