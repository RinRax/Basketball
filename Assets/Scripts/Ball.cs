using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        source.volume = gameObject.GetComponent<Rigidbody>().velocity.y / 10;
        source.Play();
    }
}
