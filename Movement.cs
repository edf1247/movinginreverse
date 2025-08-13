using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    float horizontal;
    public Rigidbody rb;
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(horizontal < 0)
        {
            animator.Play("Backwards");
        }
        if (horizontal > 0)
        {
            animator.Play("Forwards");
        }
    }
    private void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        rb.linearVelocity = new Vector3(horizontal, 0, 0) * moveSpeed;
    }
}
