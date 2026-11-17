using UnityEngine;

public class VelocityScript : MonoBehaviour
{
    public float startSpeed = 50f;

    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        // This gives the ball an initial diagonal push
        rigidBody.linearVelocity = new Vector3(startSpeed, 0, startSpeed);
    }
}