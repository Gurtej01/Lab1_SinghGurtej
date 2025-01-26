using UnityEngine;
public static class Steering
{
    public static Vector2 Seek(Rigidbody2D seeker, Vector3 target, float moveSpeed, float turnSpeed)
    {
        Vector2 currentVelocity = seeker.linearVelocity;
        Vector2 desiredVelocity = ( target - seeker.transform.position).normalized * moveSpeed;
        Vector2 seekForce = desiredVelocity - currentVelocity;

        float targetAngle = Vector3.SignedAngle(Vector3.right, desiredVelocity, Vector3.forward);

        // 2% -- Use seeker.MoveRotation to rotate the seeker towards its velocity
        seeker.MoveRotation(Mathf.MoveTowardsAngle(seeker.rotation, targetAngle, turnSpeed));
       
        Vector3 seekerPos = new Vector3(seeker.position.x, seeker.position.y, 0); // Converted Vector2 Seeker Posiion to vector3 since it wont let me add vector2 and vector3 inside DrawLine()
        Vector3 direction = Quaternion.Euler(0.0f, 0.0f, seeker.rotation) * Vector3.right;
        Debug.DrawLine(seekerPos, seekerPos + direction * 5.0f);

        // 2% -- Output seeking force (smooth acceleration leading to curved motion)
        return seekForce;
    }
}
