using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        InvokeRepeating("RandomSoundness", 2.0f, 4.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void RandomSoundness()
    {
        source.clip = sounds[Random.Range(0, sounds.Length)];
        source.PlayOneShot(source.clip);
    }
}
