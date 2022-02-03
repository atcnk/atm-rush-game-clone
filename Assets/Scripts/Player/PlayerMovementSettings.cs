using UnityEngine;

namespace ATMRush.PlayerMovement
{
    [CreateAssetMenu(menuName = "ATM Rush/Player/Movement Settings")]
    public class PlayerMovementSettings : ScriptableObject
    {
        [Header("Player's Speed")]
        [SerializeField] private float _horizontalSpeed;
        [SerializeField] private float _verticalSpeed;

        public float HorizontalSpeed { get => _horizontalSpeed; }
        public float VerticalSpeed { get => _verticalSpeed; }
    }
}
