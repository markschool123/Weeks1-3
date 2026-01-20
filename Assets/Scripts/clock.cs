using UnityEngine;

public class clock : MonoBehaviour
{
    public float speed =60;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Rotation = transform.eulerAngles;
        Rotation.z += speed * Time.deltaTime;
        transform.eulerAngles = Rotation;       
        
        
    }
}
