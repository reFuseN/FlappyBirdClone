using UnityEngine;

public class PlayerControlsKeyboard : PlayerControls
{
    public PlayerControlsKeyboard(PlayerController playerController) : base(playerController)
    {
    }

    public override void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _playerController.Jump();
    }
}
