using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip running;
    public AudioClip eating;
    private PacStudentController controller;
    private bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<PacStudentController>();

        source.clip = eating;
        source.loop = true;
        source.volume = 0.5f;
        source.Play();
        //source.PlayDelayed(8f);
    }

    // Update is called once per frame
    void Update()
    {
        //if (controller.eating() == true )
        //{
           // source.clip = eating;
           // source.loop = true;
            //source.volume = 0.5f;
            //source.Play();
        //}
        //else
        //{

            //source.clip = running;
            //source.Play();
        //}
    }
}
