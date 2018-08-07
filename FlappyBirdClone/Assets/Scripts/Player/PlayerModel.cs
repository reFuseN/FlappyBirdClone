using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerModel : ScriptableObject
{
    [SerializeField]
    private float _jumpStrength;
    public float JumpStrength { get { return _jumpStrength; } }
}
