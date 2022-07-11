using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCatchFire : MonoBehaviour
{

    //[SerializeField] 
    public ParticleSystem CatchFire;
    public ParticleSystem Shiny;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CatchFire.Play();
        }
        if (Input.GetKeyDown("2"))
        {
            CatchFire.Stop();
        }
        if (Input.GetKeyDown("3"))
        {
            Shiny.Play();
        }
        if (Input.GetKeyDown("4"))
        {
            Shiny.Stop();
        }
    }
}
