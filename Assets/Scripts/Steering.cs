using UnityEngine;

public static class Steering
{
    // "Seek is a static method that can be applied to any GameObject" -- Done for you here
    public static Vector2 Seek(Rigidbody2D seeker, Vector3 target, float moveSpeed, float turnSpeed)
    {
        Vector2 currentVelocity = seeker.linearVelocity;
        Vector2 desiredVelocity = ( target - seeker.transform.position).normalized * moveSpeed;
        Vector2 seekForce = desiredVelocity - currentVelocity;
        return seekForce;
        // 2% -- Output seeking force (smooth acceleration leading to curved motion)
        // 2% -- Use seeker.MoveRotation to rotate the seeker towards its velocity
        // (Instead of rotating towards the mouse cursor, you need to rotate it towards its velocity direction)
        // return Vector2.zero;
    }
}
