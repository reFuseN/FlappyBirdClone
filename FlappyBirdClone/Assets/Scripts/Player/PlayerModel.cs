using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerModel : ScriptableObject
{
    [SerializeField]
    private float _jumpStrength;
    public float JumpStrength { get { return _jumpStrength; } }
    [SerializeField]
    private float _movementSpeed;
    public float MovementSpeed { get { return _movementSpeed; } }
    [SerializeField]
    private Vector2 _minMaxPositionY;
    public Vector2 MinMaxPositionY { get { return _minMaxPositionY; } }
}
