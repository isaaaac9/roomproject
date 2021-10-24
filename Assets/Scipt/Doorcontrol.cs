using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doorcontrol : MonoBehaviour
{
    public bool doorOpen = false;
    public GameObject door;
    Animator animator;
    public bool audios;
    public AudioClip openAudio;
    public AudioClip closeAudio;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Openclose", doorOpen);
        if (doorOpen)
        {
            if (audios == false)
            {
                GetComponent<AudioSource>().PlayOneShot(openAudio);
                audios = true;
            }

        }
        else
        {
            if (audios == true)
            {
                GetComponent<AudioSource>().PlayOneShot(openAudio);
                audios = false;
            }
        }
    }
}
