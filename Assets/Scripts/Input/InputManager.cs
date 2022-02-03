using UnityEngine;

namespace ATMRush.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private PlayerInputData _playerInputData;

        private void Update()
        {
            _playerInputData.Horizontal = Input.GetAxis("Horizontal");
        }
    }
}