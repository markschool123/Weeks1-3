using UnityEngine;

public class NewScript : MonoBehaviour
{
    // create speed float
    float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // add speed to the x position
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition; ;

        // once the object meets the end of the screen, make it move backwards
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
    }
}
