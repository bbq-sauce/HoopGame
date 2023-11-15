using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static SceneController instance;
    public string mainMenuSceneName = "MainMenu";
    public string gameSceneName = "GameScreen";
    public string gameOverSceneName = "GameOver";
    public string youWinSceneName = "YouWon";
    private void Awake()
    {
        instance = this;
    }
    public void LoadGameScene()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(mainMenuSceneName);
    }

    public void LoadGameOverScene()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadWinScene()
    {
        SceneManager.LoadScene(youWinSceneName);
    }
    public void ExitApp()
    {
        Application.Quit();
    }
}
