using UnityEngine;

public class Teleport : MonoBehaviour
{
    public float timer;
    bool timerUp;
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
            timerUp = true;
            timer = 0;
        }
        if (timerUp == true)
        {


                Vector2 Telly = Camera.main.WorldToScreenPoint(transform.position);
                Telly.x = Random.Range(-5f, 5f);
                Telly.y = Random.Range(-5f, 5f);
                transform.position = Telly; 
                timerUp = false;

        }   
    }
}
