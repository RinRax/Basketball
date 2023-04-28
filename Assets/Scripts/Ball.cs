using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip floorSound, rimSound, backboardSound, poleSound;
    public Transform view2d;

    Rigidbody rb;
    AudioSource audioSource;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        rb.isKinematic = true;
    }

    void Update()
    {
        Controls();
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
            case "Backboard":
                toPlay = backboardSound; break;
            case "Pole":
                toPlay = poleSound; break;
            default: toPlay = floorSound; break;
        }

        Vector3 velocity = gameObject.GetComponent<Rigidbody>().velocity;
        audioSource.clip = toPlay;
        audioSource.volume = (velocity.x + velocity.y) / 10;

        audioSource.Play();
    }

    void Controls()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.isKinematic = !rb.isKinematic;
            Vector3.Lerp(transform.position, view2d.position, 1);
        }*/

        if (Input.GetMouseButtonDown(0))
        {
            rb.isKinematic = !rb.isKinematic;
            Vector3.Lerp(transform.position, view2d.position, 1);
        }

    }
}
