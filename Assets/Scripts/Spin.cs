using UnityEngine;

public class Spin : MonoBehaviour
{
    public float speed = 4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rotation = transform.eulerAngles;
        Rotation.z += speed;
        transform.eulerAngles = Rotation;
    }
}
