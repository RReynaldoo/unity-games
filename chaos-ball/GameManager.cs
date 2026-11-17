using UnityEngine;

public class GameManager : MonoBehaviour
{
    // These variables create the slots in the Inspector
    public GoalScript blue, green, red, orange;
    private bool isGameOver = false;

    void Update()
    {
        // Check if all four scripts have their 'isSolved' boolean set to true
        if (blue.isSolved && green.isSolved && red.isSolved && orange.isSolved)
        {
            isGameOver = true;
        }
    }

    void OnGUI()
    {
        if (isGameOver)
        {
            // Creates a box in the center of the screen
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box(rect, "Game Over");

            // Creates the text inside the box
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Label(rect2, "Good Job!");
        }
    }
}