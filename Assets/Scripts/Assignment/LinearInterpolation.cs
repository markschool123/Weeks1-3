using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float t = 0;
    
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        // if timer reaches 1, reset it back to 0 to loop movement
        if (t > 1)
        {
            
            t = 0;
          
        }
       // move object from start to end using a curve
       //curve eases up or down regarding the timer
        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
    

   
}
