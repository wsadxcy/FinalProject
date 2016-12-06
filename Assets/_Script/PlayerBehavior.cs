using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {

    [Header("Sounds")]
    public AudioSource Coinget;
    public AudioSource HitSound;
    [Header("GameObject")]
    public GameController gameController;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Coin"))
        {
            this.gameController.ScoreValue += 100;
            this.Coinget.Play();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.name.Contains("Exit"))
        {
            this.gameController.Victory();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            this.gameController.LivesValue -= 1;
            this.HitSound.Play();
        }
    }
}
