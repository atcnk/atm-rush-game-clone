using UnityEngine;

[CreateAssetMenu(menuName = "ATM Rush/Input/Player Input Data")]
public class PlayerInputData : ScriptableObject
{
    [Header("Axis Base Control")]
    [SerializeField] private float _horizontal;

    public float Horizontal { get => _horizontal; set => _horizontal = value; }
}