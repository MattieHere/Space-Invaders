using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;  
    public Text scoreText;  

    void Awake()
    {
   
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void UpdateScoreText(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
