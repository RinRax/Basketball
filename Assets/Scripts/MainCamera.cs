using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform view2d, view3d;

    float lerp = 0, dLerp = 0;

    void Start()
    {

    }

    void Update()
    {
        Controls();
        Vector3 pos = Vector3.Slerp(view2d.position, view3d.position, lerp);
        Quaternion rotation = Quaternion.Slerp(view2d.rotation, view3d.rotation, lerp);
        transform.position = pos;
        transform.rotation = rotation;
        lerp += dLerp * Time.deltaTime;
    }

    void Controls()
    {
        if (Input.GetMouseButtonUp(0))
        {
            lerp = 0;
            dLerp = 2f;
        }
    }
}
