using UnityEngine;
using System;

[Serializable]
public abstract class PlayerControls
{
    [SerializeField]
    protected PlayerController _playerController;

    public PlayerControls(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public abstract void Jump();
}
