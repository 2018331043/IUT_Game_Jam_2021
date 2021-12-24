using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStepAudio : MonoBehaviour
{
    [SerializeField]private AudioClip[] clip;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        
    }
    private AudioClip GetRandomClip()
    {
        return clip[UnityEngine.Random.Range(0, clip.Length)];
    }

    private void LeftFoot()
    {
        AudioClip clip = GetRandomClip();
        audio.PlayOneShot(clip);
    }
   
}
