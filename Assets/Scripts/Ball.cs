using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip floorSound, rimSound, backboardSound, poleSound;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision == null) return;

        AudioClip toPlay;

        switch (collision.gameObject.name)
        {
            case "Floor":
                toPlay = floorSound; break;
            case "Rim":
                toPlay = rimSound; break;
            default: toPlay = floorSound; break;
        }

        Vector3 velocity = gameObject.GetComponent<Rigidbody>().velocity;
        audioSource.clip = toPlay;
        audioSource.volume = (velocity.x + velocity.y) / 10;

        audioSource.Play();
    }
}
