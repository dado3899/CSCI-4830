using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour {
    private AudioSource audioSource;
    public AudioClip Scored;
    public AudioClip Victory;
    public int CollisionCount;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Scored;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    void OnCollisionEnter(Collision other)
    {
        CollisionCount += 1;
        transform.localScale *= 0.5f;
        audioSource.Play();
        if (CollisionCount == 4)
        {
            audioSource.loop = true;
            audioSource.clip = Victory;
            audioSource.Play();
            transform.localScale *= 0f;
            
        }
        
        
        
    }

}
