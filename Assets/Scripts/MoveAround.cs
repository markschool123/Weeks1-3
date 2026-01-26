using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class MoveAround : MonoBehaviour
{
    public float speed = 2f;
    public float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        // get mouse pos in world space
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePos.z = transform.position.z;

        // calculate the distance between object and mouse
        distance = Vector3.Distance(transform.position, mousePos); 

        // calculate direction from meteor to mouse
        Vector3 Move = mousePos - transform.position;

        //move meteor in that direction, affect the speed by the distance
        transform.position += Move * speed * Time.deltaTime;

    }
}
