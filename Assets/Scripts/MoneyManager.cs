using UnityEngine;
using System.Collections.Generic;

namespace ATMRush
{
    public class MoneyManager : MonoSingleton<MoneyManager>
    {
        [SerializeField] private List<GameObject> _monies = new List<GameObject>();
        public void StackMoneyToPlayer(GameObject moneyGO)
        {
            moneyGO.transform.parent = _monies[0].transform.parent;
            moneyGO.transform.localPosition = GenerateNextPosition(moneyGO);
            _monies.Add(moneyGO);

            SetMoneyProperties(moneyGO);
        }

        private void SetMoneyProperties(GameObject moneyGO)
        {
            moneyGO.tag = "Untagged";
            moneyGO.GetComponent<BoxCollider>().isTrigger = false;
        }

        private Vector3 GenerateNextPosition(GameObject moneyGO)
        {
            Vector3 nextPosition = _monies[_monies.Count - 1].transform.localPosition;
            nextPosition.z += (_monies[_monies.Count - 1].transform.localScale.z + moneyGO.transform.localScale.z) / 2;

            return nextPosition;
        }
    }
}