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
            Debug.LogError(string.Format("There is no Rigidbody2D attached to {0}", gameObject.name));
    }

    public virtual void Jump()
    {
        _rigidBody.velocity = (new Vector2(0, _playerModel.JumpStrength));
    }
}
