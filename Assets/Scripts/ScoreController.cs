using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private int currentScore = 0;

    private void OnEnable()
    {
        EventManager.OnAddPoints += HandleAddPoints;
    }

    private void OnDisable()
    {
        EventManager.OnAddPoints -= HandleAddPoints;
    }

    private void HandleAddPoints(int points)
    {
        currentScore += points;
        print(currentScore);
    }
}
