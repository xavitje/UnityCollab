using TMPro;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class OnCollisionRed : MonoBehaviour
{
    public Text score;
    public float berekenscore1;
    float berekenscore2;
    public string scoreText;
    public float currentScore = 0f;
    public TextMeshPro number;
    int highScore;
    int totalScore;
    public shoot test;
    public Texture m_MainTexture, m_Normal;
    public Material m_MainMat, m_NormalMat;
    Renderer m_Renderer;
    public static int deaths =0;
    public int deaths1;

    private void Start()
    {
        number.text = (Random.Range(-1, -11)).ToString();
        m_Renderer = GetComponent<Renderer>();
        m_Renderer.enabled = true;
        m_Renderer.sharedMaterial = m_MainMat;
    }

    //public void GetTest() => GetComponent<shoot>().main();

    public void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "bullet")
        {
            
            m_Renderer.material.EnableKeyword("_NORMALMAP");
            scoreText = number.text;
            float berekenscore1 = float.Parse(scoreText);
            berekenscore2 = berekenscore1 + 1;
            if (berekenscore2 >= 0)
            {
                m_Renderer.sharedMaterial = m_NormalMat;


            }
            number.text = berekenscore2.ToString();
            
            
        }
        else if (other.gameObject.tag == "Player")
        {
            float parsedFloat = float.Parse(number.text);
            //Debug.Log(parsedFloat.ToString());
            if (parsedFloat > 0)
            {
                currentScore = float.Parse(number.text);
                int i_currentScore = (int)currentScore;
                //Debug.Log("Dit klopt niet");
                //Debug.Log(i_currentScore);
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
            if (parsedFloat < 0)
            {
                //Debug.Log("Je bent dood");
                deaths = deaths + 1;
                deaths1 = deaths;
                Debug.Log(deaths1 + " keer dood");
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

