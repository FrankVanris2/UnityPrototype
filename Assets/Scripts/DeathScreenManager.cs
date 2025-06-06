using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenManager : MonoBehaviour
{
    [SerializeField] GameObject deathScreenPanel;

    public void ShowDeathScreen()
    {
        deathScreenPanel.SetActive(true);
        Time.timeScale = 0f; // Pause the game
    }

    public void ReplayGame()
    {
        Time.timeScale = 1f; // Resume the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void BackToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
