using UnityEngine;

public class Pulse : MonoBehaviour
{
    public AnimationCurve curve;
    public float t = 0;
    public float y; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // increase t by the time since last frame
        t += Time.deltaTime;

        // reset t back to 0, creating a loop
        if (t > 1)
        {
            t = 0;

        }
        //get curve value at time t
        y = curve.Evaluate(t);
        // set the scale based opn the curve value, making the object grow/shrink over time.
        transform.localScale = Vector2.one * curve.Evaluate(t);
        
    }
}
