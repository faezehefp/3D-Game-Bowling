using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallStrike : MonoBehaviour
{
    [SerializeField] private AudioSource pinSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            pinSound.Play();
        }
    }

}