using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Arrow;
    void Start()
    {
        InvokeRepeating("ArrowShot", 0, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ArrowShot()
    {
        Instantiate(Arrow, new Vector3(Random.Range(-3, 3), 10, 0), Quaternion.identity);
    }
}
