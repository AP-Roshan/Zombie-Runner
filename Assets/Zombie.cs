using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject zombieprefab;


    void Start()
    {

    }

    void Update()
    {
        transform.localPosition -= new Vector3(4f * Time.deltaTime, 0, 0);

    }

}
