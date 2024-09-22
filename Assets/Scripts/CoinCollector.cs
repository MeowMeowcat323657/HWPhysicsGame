using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField]private int _coinAmount;
    [SerializeField] private int _leveltime;
    [SerializeField] private Rigidbody _characterRigidbody;
    private float _time;
    void Update()
    {
        _time += Time.deltaTime;
        if (_time >= _leveltime)
        {
            _characterRigidbody.isKinematic = true;
            Debug.Log("Вы проиграли");
        }
        if (_coinAmount == 0)
        {
            _characterRigidbody.isKinematic = true;
            Debug.Log("Вы Выиграли");
        }
    }

    public void CollectCoin()
    {
        _coinAmount -= 1;
    }
}
