using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovemant : MonoBehaviour
{
    private float speed;
    Vector3 vec;
    private void Start()
    {
        vec.x = -78f;
        vec.y = -5f;
        vec.z = -1f;
    }
    private void Update()
    {
        speed = PlayerPrefs.GetFloat("Speed");

        this.transform.position = Vector3.MoveTowards(this.transform.position, vec, Time.deltaTime * speed);
        if (this.transform.position == vec)
        {
            Destroy(this.gameObject);
        }
    }
}
