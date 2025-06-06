using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform player; // Assign in Inspector
    [SerializeField] float moveSpeed = 5f;
    bool isActive = true;

    void Update()
    {
        if (!isActive || player == null) return;

        // Move towards the player
        Vector3 direction = (player.position - transform.position).normalized;
        Vector3 move = direction * moveSpeed * Time.deltaTime;
        transform.position += move;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (other.CompareTag("Player"))
            {
                // "Kill" the player (make it disappear)
                other.gameObject.SetActive(false);
                isActive = false;
                //TODO: Add more game logic after the player dies
            }
        }
    }
}
