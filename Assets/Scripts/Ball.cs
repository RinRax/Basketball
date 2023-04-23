using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioSource floorSound, rimSound, backboardSound, poleSound;

    void Start()
    {
        floorSound = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Floor")
        {
            floorSound.volume = gameObject.GetComponent<Rigidbody>().velocity.y / 10;
            floorSound.Play();
        }

        if (collision.gameObject.name == "Rim")
        {
            rimSound.volume = gameObject.GetComponent<Rigidbody>().velocity.y / 10;
            rimSound.Play();
        }

        if (collision.gameObject.name == "Backboard")
        {
            backboardSound.volume = gameObject.GetComponent<Rigidbody>().velocity.y / 10;
            backboardSound.Play();
        }

        if (collision.gameObject.name == "Pole")
        {
            poleSound.volume = gameObject.GetComponent<Rigidbody>().velocity.y / 10;
            poleSound.Play();
        }
    }
}
