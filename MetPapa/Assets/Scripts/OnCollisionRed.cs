using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OnCollisionRed : MonoBehaviour
{
    public Text score;
    public float currentScore = 0f;
    public TextMeshPro number;
    int highScore;
    int totalScore;

    private void Start()
    {
        number.text = (Random.Range(-1, -11)).ToString();
    }

    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Player")
        {
            float parsedFloat = float.Parse(number.text);

            if (parsedFloat >= 0)
            {
                currentScore = float.Parse(number.text);
                int i_currentScore = (int)currentScore;
                Debug.Log(i_currentScore);
                if (PlayerPrefs.HasKey("Score"))
                {
                    highScore = PlayerPrefs.GetInt("Score");
                    totalScore = highScore - i_currentScore;
                    PlayerPrefs.SetInt("Score", totalScore);
                    PlayerPrefs.Save();
                }
                else
                {
                    PlayerPrefs.SetInt("Score", i_currentScore);
                    PlayerPrefs.Save();
                }
            }
            else
            {
                Debug.Log("You are dead!");
                currentScore = float.Parse(number.text);
                int i_currentScore = (int)currentScore;
                if (PlayerPrefs.HasKey("Score"))
                {
                    highScore = PlayerPrefs.GetInt("Score");
                    totalScore = highScore + i_currentScore;
                    PlayerPrefs.SetInt("Score", totalScore);
                    PlayerPrefs.Save();
                }
                else
                {
                    PlayerPrefs.SetInt("Score", i_currentScore);
                    PlayerPrefs.Save();
                }
            }

        }
    }
}

