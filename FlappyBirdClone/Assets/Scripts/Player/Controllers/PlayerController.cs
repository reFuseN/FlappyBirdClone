using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class PlayerController : MonoBehaviour
{
    [SerializeField]
    protected PlayerModel _playerModel;
    protected Rigidbody2D _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        if (_rigidBody == null)
            Debug.LogError(string.Format("There is no Rigidbody2D attached to {0}", name));
        if (_playerModel == null)
            Debug.LogError(string.Format("There is no Player Model assigned to PlayerController of {0}", name));
    }

    public virtual void Jump()
    {
        _rigidBody.velocity = (new Vector2(0, _playerModel.JumpStrength));
    }

    private void Update()
    {
        Move();
        DeathCheck();
    }

    public virtual void Move()
    {
        transform.position += new Vector3(_playerModel.MovementSpeed * Time.deltaTime, 0, 0);
    }

    public virtual void DeathCheck()
    {
        if (transform.position.y < _playerModel.MinMaxPositionY.x || transform.position.y > _playerModel.MinMaxPositionY.y)
            Die();
    }

    public virtual void Die()
    {
        transform.DetachChildren();
        Destroy(gameObject);
    }
}
