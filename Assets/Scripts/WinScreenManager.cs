using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenManager : MonoBehaviour
{
    [SerializeField] GameObject winScreenPanel;

    public void ShowWinScreen()
    {
        winScreenPanel.SetActive(true);
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
