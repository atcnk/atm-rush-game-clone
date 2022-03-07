using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using DG.Tweening;

namespace ATMRush
{
    public class MoneyManager : MonoSingleton<MoneyManager>
    {
        [SerializeField] private List<GameObject> _monies = new List<GameObject>();
        [SerializeField] private Vector3 _moneyScale = new Vector3(1.5f, 0.5f, 0.5f);
        [SerializeField] private float _scaleMultiplier = 1.5f;
        [SerializeField] private float _scaleDuration = 0.1f;
        [SerializeField] private float _movementDuration = 1f;
         
        public void StackMoneyToPlayer(GameObject moneyGO)
        {
            moneyGO.transform.parent = _monies[0].transform.parent;
            moneyGO.transform.localPosition = GenerateNextPosition(moneyGO);
            _monies.Add(moneyGO);

            SetMoneyProperties(moneyGO);
            StartCoroutine(ChangeMoniesScale());
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

        private IEnumerator ChangeMoniesScale()
        { 
            for (int i = _monies.Count - 1; i > 0; i--)
            {
                int a = i;
                _monies[i].transform.DOScale(_moneyScale * _scaleMultiplier, _scaleDuration).OnComplete(
                    () => _monies[a].transform.DOScale(_moneyScale, _scaleDuration));

                yield return new WaitForSeconds(_scaleDuration / 2);
            }
        }

        public void Glide()
        {
            for (int i = 1; i < _monies.Count; i++)
            {
                int a = i;
                Vector3 tempPosition = _monies[a].transform.localPosition;
                tempPosition.x = _monies[a - 1].transform.localPosition.x;
                Debug.Log("Moving " + _monies[a] + " from " + _monies[a].transform.localPosition + " to " + tempPosition);
                _monies[a].transform.DOLocalMove(tempPosition, _movementDuration);
            }
        }
    }
}