using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }

    public int Score { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void AddScore(int value)
    {
        Score += value;
        UIManager.Instance.UpdateScoreText(Score);
    }

    public void ResetScore()
    {
        Score = 0;
        UIManager.Instance.UpdateScoreText(Score);
    }
}
