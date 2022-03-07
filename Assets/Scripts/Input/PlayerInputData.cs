using UnityEngine;

namespace ATMRush.PlayerInput
{
    [CreateAssetMenu(menuName = "ATM Rush/Input/Player Input Data")]

    public class PlayerInputData : ScriptableObject
    {
        [Header("Axis Base Control")]
        [SerializeField] private float _horizontal;

        [Header("Button Press Control")]
        [SerializeField] private bool _isPressed;

        public float Horizontal { get => _horizontal; set => _horizontal = value; }
        public bool IsPressed { get => _isPressed; set => _isPressed = value; }
    }
}