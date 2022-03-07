using UnityEngine;

namespace ATMRush.Player
{
    public class Player : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Money"))
            {
                MoneyManager.Instance.StackMoneyToPlayer(other.gameObject);
            }
        }
    }
}