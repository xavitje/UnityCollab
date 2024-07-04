using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    
    public float speed = 10f;
    public float movingSpeed = 0f;

    public Rigidbody rb;

    void FixedUpdate()
    {
        
        float xMove = Input.GetAxisRaw("Horizontal");

        if (xMove < 0 )
        {
            xMove = -0.5f;
        }
            
        else if (xMove > 0)
        {
            xMove = 0.5f;
        }
        rb.velocity = new Vector3(xMove, 0f, movingSpeed) * speed;

        if (rb.position.y < 0f )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}
