using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OnCollisionGreen : MonoBehaviour
{
    public Text score;
    public float berekenscore1;
    float berekenscore2;
    public string scoreText;
    public float currentScore = 0;
    public TextMeshPro number;
    int highScore;
    int totalScore;

    private void Start()
    {
        number.text = (Random.Range(1, 11)).ToString();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            scoreText = number.text;
            float berekenscore1 = float.Parse(scoreText);
            berekenscore2 = berekenscore1 + 1;
            number.text = berekenscore2.ToString();
            
        }
        if (other.gameObject.tag == "Player")
        {
            
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
