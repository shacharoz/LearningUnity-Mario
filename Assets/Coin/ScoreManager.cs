using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int CoinCounter;
    private int TotalScore;
    public int BaseScoreFactor = 100;

    public Text TotalScoreTextfield;
    //public Text CoinCollectedTextfield;

    void Start()
    {
        
    }

    /// <summary>
    /// happens every time the player collects a coin.
    /// add score to the total score
    /// </summary>
    public void IncreaseCoin()
    {
        CoinCounter++;

        CalculatePoints();

        TotalScoreTextfield.text = "Score: " + TotalScore.ToString();
    }

    public void CalculatePoints()
    {
        TotalScore = BaseScoreFactor * CoinCounter;
    }

    public void SetScoreMultiplier(int multiplier)
    {
        BaseScoreFactor *= multiplier;
    }
}