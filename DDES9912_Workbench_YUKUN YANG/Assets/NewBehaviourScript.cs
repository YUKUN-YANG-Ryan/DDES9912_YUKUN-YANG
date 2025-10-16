using UnityEngine;

public class Helloworld : MonoBehaviour
{
    public int a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = 1;
   //Hello there is internal documentation that is very useful :D
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello world"+a);//"hello world n"
        a = a + 1;
         
    }
}
