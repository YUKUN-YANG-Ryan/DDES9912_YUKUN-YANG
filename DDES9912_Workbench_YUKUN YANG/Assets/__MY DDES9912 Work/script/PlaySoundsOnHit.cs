using UnityEngine;

public class PlaySoundsOnHit : MonoBehaviour
{ 
    private AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I AM HIT!");

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("YOU FORGOT TO PUT AN AUDIOSOUCE ON AND ASSIGN A CLIP");
        }
        
     }

}
