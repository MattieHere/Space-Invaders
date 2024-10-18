using UnityEngine;
using UnityEngine.UI;

public class SpriteLooper : MonoBehaviour
{
    public Sprite[] sprites;
    public float frameRate = 0.1f; 
    private Image image; 
    private int currentFrame;
    private float timer;

    void Start()
    {
        image = GetComponent<Image>();
        currentFrame = 0;
        timer = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= frameRate)
        {
            timer = 0f;
            currentFrame = (currentFrame + 1) % sprites.Length;
            image.sprite = sprites[currentFrame];
        }
    }
}