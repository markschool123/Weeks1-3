using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanges : MonoBehaviour
{
    public Color col; 
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //if (Keyboard.current.anyKey.wasPressedThisFrame == true)
      //{
          //PickARandomColour();
      //}

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

       if (spriteRenderer.bounds.Contains (mousePos)==true)
        {
            spriteRenderer.color = col; 
        }
        else
        {
            spriteRenderer.color = Color.white;
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }
}


