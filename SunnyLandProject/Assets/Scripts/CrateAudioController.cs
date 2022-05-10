using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateAudioController : MonoBehaviour
{
    public AudioSource audioSourceImpact;
    public AudioSource audioSourceRumble;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSourceRumble.Play();
        audioSourceImpact.Play();
    }
}
