using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float jumpForce = 1;

    private Rigidbody2D rigidybody; 
    
    private void Awake()
    {
        rigidybody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            rigidybody.linearVelocity += Vector2.up * jumpForce;
        }
    }
}
