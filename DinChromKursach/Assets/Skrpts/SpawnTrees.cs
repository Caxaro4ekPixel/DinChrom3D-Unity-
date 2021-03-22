using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrees : MonoBehaviour
{
    public GameObject[] tree;
    void Start()
    {
        StartCoroutine("SpawnTreess");
    }
    IEnumerator SpawnTreess()
    {
        while (true)
        {
            if (PlayerPrefs.GetInt("Location") == 1)
            {
                if (Random.Range(0, 2) == 1)
                {
                    Instantiate(tree[Random.Range(0, 3)], new Vector3(21f, -4f, -1f), Quaternion.identity);
                }
                else
                {
                    Instantiate(tree[Random.Range(0, 3)], new Vector3(21f, -4f, 5f), Quaternion.identity);
                }
            }
            if (PlayerPrefs.GetInt("Location") == 2)
            {
                if (Random.Range(0, 2) == 1)
                {
                    Instantiate(tree[4], new Vector3(21f, -4f, -1f), Quaternion.identity);
                }
                else
                {
                    Instantiate(tree[4], new Vector3(21f, -4f, 5f), Quaternion.identity);
                }
            }
            yield return new WaitForSeconds(Random.Range(2,10));
        }
    }
}
