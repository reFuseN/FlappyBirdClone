using UnityEngine;

public class PlayerControlsAbstractFactory : MonoBehaviour
{
    [SerializeField]
    private PlayerController _playerController;
    private PlayerControlsBase _controls;

    private void Awake()
    {
        if (Application.isMobilePlatform)
            _controls = new PlayerControlsTouch(_playerController);
        else
            _controls = new PlayerControlsKeyboard(_playerController);
    }

    private void Update()
    {
        _controls.Jump();
    }
}
