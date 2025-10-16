using UnityEngine;

public class Spin : MonoBehaviour
{
    public float ySpeed;
    public float xSpeed;
    public float zSpeed;
    public float yAcceleration;
    public float xAcceleration;
    public float zAcceleration;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime);

        ySpeed += yAcceleration * Time.deltaTime;
        xSpeed += xAcceleration * Time.deltaTime;
        zSpeed += zAcceleration * Time.deltaTime;
    }

    public void Stop()
    {
        ySpeed = 0;
        yAcceleration = 0;
        xSpeed = 0;
        xAcceleration = 0;
        zSpeed = 0;
        zAcceleration = 0;
    }

    public void SetSpeedz(float newSpeed)
    {

        zSpeed = newSpeed;

    }
    public void SetSpeedy(float newSpeed)
    {
        ySpeed = newSpeed;
    }


    public void SetAcceleration(float newAcceleration)
    {
        zAcceleration = newAcceleration;

    }
    
}
