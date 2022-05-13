using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAudioController : MonoBehaviour
{
    AudioSource[] allAudioSources;
    AudioSource impact;
    AudioSource rumble;
    Rigidbody2D rb;
  
    // Start is called before the first frame update
    void Start()
    {
        allAudioSources = GetComponents<AudioSource>();
        impact = allAudioSources[0];
        rumble = allAudioSources[1];

        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       impact.Play();
       rumble.Play();
    }
}
