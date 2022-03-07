using UnityEngine;
using ATMRush.PlayerInput;

namespace ATMRush.Player.Movement
{
    public class PlayerMovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody _playerRigidbody;
        [SerializeField] private Transform _shoppingCartTransform;
        [SerializeField] private PlayerInputData _playerInputData;
        [SerializeField] private PlayerMovementSettings _playerMovementSettings;

        private void Update()
        {
            Move();
            GlidePlayer();
        }

        private void Move()
        {
            _playerRigidbody.MovePosition(_playerRigidbody.position + (_playerRigidbody.transform.forward * _playerMovementSettings.VerticalSpeed * Time.deltaTime));
            _shoppingCartTransform.Translate(Vector3.right * _playerInputData.Horizontal * _playerMovementSettings.HorizontalSpeed * Time.deltaTime);
        }

        private void GlidePlayer()
        {
            if (_playerInputData.IsPressed == false)
            {
                return;
            }

            MoneyManager.Instance.Glide();
        }
    }
}
