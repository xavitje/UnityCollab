using Unity.VisualScripting;
using UnityEngine;

public class objectRemover : MonoBehaviour
{
    public GameObject objectToFind;
    string tagName = "GameObject";
    public Rigidbody rb;
    public GameObject objectToReplace;

    
    
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == tagName)
        {
            objectToFind = GameObject.FindGameObjectWithTag(tagName);
            objectToReplace = other.GetComponent<GameObject>();
            rb = other.GetComponent<Rigidbody>();
            Destroy(objectToReplace);
            
        }
        
        

    }

}
