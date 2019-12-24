using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Item that when used changes to the next song, when out of songs turns off, when used while off, plays first song.
/// 
/// TODO; It should auto play, randomise order potentially and go to next track when used.
///     In other words, act kind of like the radio in a GTA style game.
/// </summary>
[RequireComponent(typeof(AudioSource))]
public class BoomBoxItem : InteractiveItem
{
    //TODO: you will need more data than this, like clips to play and a way to know which clip is playing
    public  AudioSource audioSource;

    int i = 0;

    public AudioClip[] songs;


    protected override void Start()
    {
        base.Start();
        audioSource.loop = true;
        



    }

    
    public void PlayClip()
    {
        //TODO; this is where you might want to setup and ensure the desire clip is playing on the source
    }

    public override void OnUse()
    {
        base.OnUse();
        audioSource.clip = songs[Random.Range(0, songs.Length)];
        audioSource.Play();
        i++;


        if (i == songs.Length - 1)
            i = 0;

        //TODO; this where we need to go to next track and start and stop playing
    }
}
