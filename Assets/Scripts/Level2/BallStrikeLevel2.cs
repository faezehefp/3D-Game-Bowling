using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStrikeLevel2 : MonoBehaviour
{
     [SerializeField] private AudioSource pinSound;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Ball2"))
        {
            pinSound.Play();
        }
    }
}
