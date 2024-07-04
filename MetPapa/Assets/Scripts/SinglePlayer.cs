using UnityEngine;
using UnityEngine.SceneManagement;

public class SinglePlayer : MonoBehaviour
{
    
    public void JoinSingle()
    {
        SceneManager.LoadScene("SinglePlayer");
    }
}
