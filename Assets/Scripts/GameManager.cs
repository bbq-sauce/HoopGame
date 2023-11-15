using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] int playerScore = 0;
    [SerializeField] int aiScore = 0;

    public TMP_Text playerScoreText;
    public TMP_Text aiScoreText;

   
   // public TMP_Text winnerText;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        UpdateScoreUI();
    } 

    public void PlayerScored()
    {
        playerScore++;
        Debug.Log(playerScore);
        UpdateScoreUI();
        CheckWinCondition();
    }

    public void AIScored()
    {
        aiScore++;
        Debug.Log(aiScore);
        UpdateScoreUI();
        CheckWinCondition();
    }

    void UpdateScoreUI()
    {
        playerScoreText.text = playerScore.ToString();
        aiScoreText.text =  aiScore.ToString();
    }

    void CheckWinCondition()
    {
        if (playerScore == 3 || aiScore == 3)
        {
            // Display game over screen
            //SceneController.instance.LoadGameOverScene();

            // Determine the winner and display it
           if (playerScore > aiScore)
                SceneController.instance.LoadWinScene();
            else if (aiScore > playerScore)
                SceneController.instance.LoadGameOverScene();
            
        }
    }
}
