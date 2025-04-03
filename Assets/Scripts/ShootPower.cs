
using UnityEngine;

public class ShootPower : PowerBase
{
    #region Fields
    
    private float _bulletSpeed = 50;
    
    #endregion

    #region Public Methods

    public override void ActivatePower()
    {
        Shoot();
    }

    #endregion

    #region Private Methods

    private void Shoot()
    {
        GameObject _bullet = Instantiate(GameManager.Instance.BulletPrefab, transform.position, Quaternion.identity);
        _bullet.GetComponent<Rigidbody>().velocity = Vector3.forward * _bulletSpeed;
    }

    #endregion
}