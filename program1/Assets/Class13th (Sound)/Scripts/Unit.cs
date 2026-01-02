using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioSource audioSource;
    // Start is called before the first frame update
    private void Emit()
    {
        audioSource.clip = Resources.Load<AudioClip>("Attack");
        audioSource.Play();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
