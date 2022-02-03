using UnityEngine;
using ATMRush.PlayerInput;

namespace ATMRush.Player.Movement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private PlayerInputData _playerInputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.forward * _playerMovementSettings.VerticalSpeed * Time.deltaTime));
            _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.right * _playerInputData.Horizontal * _playerMovementSettings.HorizontalSpeed * Time.deltaTime));
        }
    }
}
