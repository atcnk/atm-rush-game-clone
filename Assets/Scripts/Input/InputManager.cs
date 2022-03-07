using UnityEngine;

namespace ATMRush.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private PlayerInputData _playerInputData;

        private void Update()
        {
            _playerInputData.Horizontal = Input.GetAxis("Horizontal");

            if (Input.GetButton("Horizontal"))
            {
                _playerInputData.IsPressed = true;
                return;
            }

            if (Input.GetButtonUp("Horizontal"))
            {
                _playerInputData.IsPressed = false;
                return;
            }
        }
    }
}