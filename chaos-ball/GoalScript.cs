using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool isSolved = false;

    void OnTriggerEnter(Collider collider)
    {
        GameObject collidedWith = collider.gameObject;

        // Check if the ball's tag matches the goal's tag
        if (collidedWith.tag == gameObject.tag)
        {
            isSolved = true;
            // This turns off the light when the goal is reached
            GetComponent<Light>().enabled = false; 
            Destroy(collidedWith);
        }
    }
}