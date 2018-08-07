using UnityEngine;

public class PlayerControlsTouch : PlayerControls
{
    public PlayerControlsTouch(PlayerController playerController) : base(playerController)
    {
    }

    public override void Jump()
    {
        if (Input.GetTouch(0).phase == TouchPhase.Began)
            _playerController.Jump();
    }
}
