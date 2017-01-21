using UnityEngine;
using System.Collections;

public class CubeMove : MonoBehaviour
{


    public float speed = 1.5f;
    public float spacing = 1.0f;
    private Vector3 pos;

    void Start()
    {
        pos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            pos.z += spacing;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            pos.z -= spacing;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            pos.x -= spacing;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            pos.x += spacing;
        }


        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);
    }
}
