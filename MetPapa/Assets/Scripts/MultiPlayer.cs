using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MultiPlayer : MonoBehaviour
{
    public void JoinMulti()
    {
        SceneManager.LoadScene("Multiplayer");
    }
}
