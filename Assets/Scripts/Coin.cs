/**
 * Coin.cs
 * By: Frank Vanris
 * This script handles the coin collection logic in the game.
 * When a player collides with a coin, it is collected and destroyed.
 */

using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.Instance.CollectCoin();
            Destroy(gameObject);
        }
    }
}
