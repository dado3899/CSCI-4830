using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour {
    public BallPrefab ballPrefab;
    private AudioSource audioSource;
    public AudioClip Pew;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Pew;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            BallPrefab ball = Instantiate<BallPrefab>(ballPrefab);
            ball.transform.localPosition = transform.position;

            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(500, 750));
            audioSource.Play();
        }
	}
}
