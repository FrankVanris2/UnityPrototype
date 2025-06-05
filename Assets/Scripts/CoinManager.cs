/**
 * CoinManager.cs
 * By: Frank Vanris
 * This script manages the collection of coins in the game.
 * It keeps track of the total number of coins and updates the UI accordingly.
 */

using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public static CoinManager Instance { get; private set; }

    [SerializeField] Text coinText;
    [SerializeField] int totalCoins = 5;
    int coinsCollected = 0;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    void Start()
    {
        UpdateUI();
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateUI();
    }

    void UpdateUI()
    {
        coinText.text = $"Coins collected: {coinsCollected}/{totalCoins}";
    }
}
