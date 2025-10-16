using UnityEngine;

public class fanspin : MonoBehaviour
 

{
    //

public class SinYRotation : MonoBehaviour
{
    public Vector3 startRotation; 
    public float currentAngle;     
    public float sinValue;
    public float rangeFactor;      
    public float bobSpeed;        

    void Start()
    {
        startRotation = transform.localEulerAngles;
    }

    void Update()
    {
        sinValue = Mathf.Sin(currentAngle * Mathf.Deg2Rad);
        
        
        float rotationAngle = sinValue * rangeFactor;
        
        transform.localEulerAngles = new Vector3(
            startRotation.x,
            startRotation.y + rotationAngle,
            startRotation.z
        );

        currentAngle += bobSpeed * Time.deltaTime;
    }
}
}

