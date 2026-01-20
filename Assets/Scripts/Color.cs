using UnityEngine;

public class myColor : MonoBehaviour
{
    public float timer;
     public SpriteRenderer spriteRenderer;
    public Color col;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {

            timer = 0;
           
        }
    }
}
