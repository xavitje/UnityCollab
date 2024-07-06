using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class lifemanager : MonoBehaviour
{
    public GameObject gameobject;
    public Text hart1;
    public Text hart2;
    public Text hart3;
    public float deaths1;
    
    void Start()
    {

    }

    void FixedUpdate()
    {
        //deaths1 = gameobject.GetComponent<OnCollisionRed>().deaths;
        deaths1 = OnCollisionRed.deaths;
        if (deaths1 == 1)
        {
            hart1.text = " ";
        }
        if (deaths1 == 2)
        {
            hart2.text = " ";
        }
        if (deaths1 == 3)
        {
            hart3.text = " ";
        }
        if (deaths1 >=4)
        {
            hart1.text= "❤";
            hart2.text= "❤";
            hart3.text= "❤";
            OnCollisionRed.deaths = 0;
            deaths1 = 0;
            Debug.Log("Het spel word herstart!");
            PlayerPrefs.SetInt("Score", 0);
            SceneManager.LoadScene("Restart");
        }
        //Debug.Log(deaths);
    }
}
