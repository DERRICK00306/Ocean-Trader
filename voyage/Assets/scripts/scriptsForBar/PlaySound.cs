using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundPlayer1;
    public AudioSource soundPlayer2;
    public AudioSource soundPlayer3;
    public AudioSource soundPlayer4;

    public void PlayThisSoundEffect1()
    {
        soundPlayer1.Play();
    }

    public void PlayThisSoundEffect2()
    {
        soundPlayer2.Play();
    }

    public void PlayThisSoundEffect3()
    {
        soundPlayer3.Play();
    }

    public void PlayThisSoundEffect4()
    {
        soundPlayer4.Play();
    }
}
