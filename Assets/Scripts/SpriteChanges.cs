using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteChanges : MonoBehaviour
{
    public Color col; 
    public SpriteRenderer spriteRenderer;
    public List<Sprite> barrels;
    
    public int randomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PickARandomSpirite();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.anyKey.wasPressedThisFrame == true)
        {
            //PickARandomColour();
            if (barrels.Count > 0)
            { 
            PickARandomSpirite();
        }
    }

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());

       if (spriteRenderer.bounds.Contains (mousePos)==true)
        {
            spriteRenderer.color = col; 
        }
        else
        {
            spriteRenderer.color = Color.white;
        }

       if (Mouse.current.leftButton.wasPressedThisFrame == true && barrels.Count > 0);
        {
            barrels.RemoveAt(0);
        }
    }

    void PickARandomColour()
    {
        spriteRenderer.color = Random.ColorHSV(); 
    }

    void PickARandomSpirite()


    {

        randomNumber = Random.Range(0, barrels.Count);

         spriteRenderer.sprite = barrels[randomNumber];
        }
    }


