using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRock : MonoBehaviour
{
    private float speed;
    Vector3 vec;
    private void Start()
    {
        vec.x = -21f;
        vec.y = -4f;
        vec.z = this.transform.position.z;
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
