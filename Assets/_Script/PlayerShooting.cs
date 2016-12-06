using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    // PUBLIC VARIABLES FOR TESTING
    public AudioSource RifleShotSound;
    public Transform PlayerCam;

    // PRIVATE VARIABLES

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame (for Physics)
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // need a variable to hold the location of our Raycast Hit
            RaycastHit hit;
            // Play Rifle Sound
            this.RifleShotSound.Play();
            // if raycast hits an object then do something...
            if (Physics.Raycast(this.PlayerCam.position, this.PlayerCam.forward, out hit))
            {

                if (hit.transform.gameObject.CompareTag("Enemy"))
                {
                    Destroy(hit.transform.gameObject);
                }
            }


        }
    }

}
