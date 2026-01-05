using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public enum AnimationState
    {
        Idle,
        Walk,
        Attack,
        Die
    }

    [SerializeField] AudioSource audioSource;
    [SerializeField] Animator animator; 
    [SerializeField] int index = 0;
    [SerializeField] AnimationState state;
    
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void Transition(int count)
    {
        if (count == 0)
        {
            state = (AnimationState)((int)state %3);
            return;
        }
        index += count;
        if (index % 3 == 0)
        {
            state++;
        }
    }
   

    public void Emit()
    {
        Debug.Log(state.ToString());
        audioSource.clip = Resources.Load<AudioClip>(state.ToString());
        audioSource.Play();
    }
}
