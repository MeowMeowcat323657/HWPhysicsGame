using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        CoinCollector coinCollector = other.GetComponent<CoinCollector>();

        if (coinCollector != null)
        {
            coinCollector.CollectCoin();
            Destroy(gameObject);
        }
    }

}
