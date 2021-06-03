using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private int CoinCounter;
    private int TotalScore;
    public int BaseScoreFactor = 100;

    public Text TotalScoreTextfield;
    public Text CoinCollectedTextfield;

    void Start()
    {
        
    }

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