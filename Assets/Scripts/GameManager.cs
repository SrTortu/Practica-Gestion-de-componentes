using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Properties

    public GameObject BulletPrefab => _bulletPrefab;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                return null;

            return _instance;
        }
    }

    #endregion

    #region Fields

    [SerializeField] private GameObject _bulletPrefab;
    private static GameManager _instance;

    #endregion

    #region Unity Callbacks

    private void Awake()
    {
        if (_instance == null)
            _instance = this;
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
    }

    #endregion
}