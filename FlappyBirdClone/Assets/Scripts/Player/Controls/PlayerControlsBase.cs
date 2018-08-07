using UnityEngine;
using System;

[Serializable]
public abstract class PlayerControlsBase
{
    [SerializeField]
    protected PlayerController _playerController;

    public PlayerControlsBase(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public abstract void Jump();
}
