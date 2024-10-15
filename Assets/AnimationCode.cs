using UnityEngine;
using UnityEngine.UI;

public class SpriteLooper : MonoBehaviour
{
    public Sprite[] sprites;
    public float frameRate = 0.1f; 
    private Image imageComponent; 
    private int currentFrame;
    private float timer;

    void Start()
    {
        imageComponent = GetComponent<Image>();
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
            imageComponent.sprite = sprites[currentFrame];
        }
    }
}