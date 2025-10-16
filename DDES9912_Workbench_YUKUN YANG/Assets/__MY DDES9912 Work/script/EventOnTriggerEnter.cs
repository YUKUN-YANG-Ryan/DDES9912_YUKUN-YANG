using UnityEngine;
using UnityEngine.Events;

public class EventOnTriggerENter : MonoBehaviour
{
     public UnityEvent whatever;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ON TRIGGER ENTER..LALALLA:" + other.name);
        whatever.Invoke();
    }
}
