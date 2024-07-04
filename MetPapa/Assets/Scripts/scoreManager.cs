using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text score;
    int currentscore;

    void FixedUpdate()
    {
        currentscore = PlayerPrefs.GetInt("Score");
        score.text = currentscore.ToString();
    }
}
