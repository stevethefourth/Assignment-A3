using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningSound : MonoBehaviour
{
    AudioSource running;
    // Start is called before the first frame update
    void Start()
    {
        running = GetComponent<AudioSource>();
        running.PlayDelayed(8f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
