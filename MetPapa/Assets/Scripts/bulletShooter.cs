using UnityEngine;
using System.Collections;

public class bulletShooter : MonoBehaviour
{
    public Rigidbody rb;
    public GameObject bullet;

    public Transform target;
    public float offset;

    private void Start()
    {
        rb.position = new Vector3(target.position.x + offset, 0, 0);
        // rb.AddForce(new Vector3(0f, 0f, 0.2f));
    }
    private void OnMouseDown()
    {
        Debug.Log("Je hebt geklikt");
        GameObject clone = Instantiate(bullet, target.position, Quaternion.identity); //.AngleAxis(0, Vector3.left));
        // rb.AddForce(new Vector3(0f, 0f, 0.5f));
        

    }

    void FixedUpdate()
    {
        rb.position = new Vector3(target.position.x + offset, 1.4f, 0.585f);


    }
}
