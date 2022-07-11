using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCatchFire : MonoBehaviour
{
    [SerializeField] ParticleSystem CatchFire;
    void Start()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CatchFire.Play();
            Destroy(gameObject, 8);
        }
    }
}
