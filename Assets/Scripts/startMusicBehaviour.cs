using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMusicBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.tag == "MainCamera")
            playForThisAmount(7.9f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time == 10f)
            playForThisAmount(1f);
    }
    

    public void playForThisAmount(float time)
    {
        GetComponent<AudioSource>().Play();
        Invoke("stopTheAudio", time);
    }

    private void stopTheAudio()
    {
        GetComponent<AudioSource>().Stop();
    }
}
