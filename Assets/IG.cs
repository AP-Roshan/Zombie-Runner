using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IG : MonoBehaviour
{
    public GameObject spawn;
    public GameObject Zombie;
    void Start()
    {
        InvokeRepeating("a", 1, 2f);
    }

    void Update()
    {
        transform.position -= new Vector3(4f * Time.deltaTime, 0, 0);
    }
    void a()
    {
        spawn = Instantiate(Zombie,transform.position,Quaternion.identity) as GameObject;
    }
}
