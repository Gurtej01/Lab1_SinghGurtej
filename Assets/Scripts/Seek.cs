using UnityEngine;
public class Seek : MonoBehaviour
{
    public GameObject target;
    [SerializeField] float moveSpeed = 10.0f;
    [SerializeField] float turnSpeed = 720.0f;    
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 seekForce = Steering.Seek(rb, target.transform.position, moveSpeed, turnSpeed * Time.deltaTime);
        rb.AddForce(seekForce);
    }
}
