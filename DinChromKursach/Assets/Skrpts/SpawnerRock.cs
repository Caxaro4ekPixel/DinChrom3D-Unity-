using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRock : MonoBehaviour
{
    public GameObject[] Rock;
    void Start()
    {
        StartCoroutine("SpawnTreess");
    }
    IEnumerator SpawnTreess()
    {
        while (true)
        {
            switch (PlayerPrefs.GetInt("Location"))
            {
                case 1:
                    Instantiate(Rock[Random.Range(0, 28)], new Vector3(21f, -4f, 2f), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(Rock[Random.Range(28, 34)], new Vector3(21f, -4f, 2f), Quaternion.identity);
                    break;
                default:
                    Instantiate(Rock[Random.Range(0, 28)], new Vector3(21f, -4f, 2f), Quaternion.identity);
                    break;
            }
            yield return new WaitForSeconds(Random.Range(10, 25));
        }
    }
}
