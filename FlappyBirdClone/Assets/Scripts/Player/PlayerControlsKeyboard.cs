using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlsKeyboard : MonoBehaviour
{
    [SerializeField]
    private PlayerController _playerController;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            _playerController.Jump();
    }
}
