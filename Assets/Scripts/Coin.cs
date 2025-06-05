/**
 * Coin.cs
 * By: Frank Vanris
 * This script handles the coin collection logic in the game.
 * When a player collides with a coin, it is collected and destroyed.
 */

using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float spinSpeed = 90f;

    void Update()
    {
        // Rotate the coin around it's Y-axis
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager.Instance.CollectCoin();
            Destroy(gameObject);
        }
    }
}
