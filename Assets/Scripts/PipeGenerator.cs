using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGene : MonoBehaviour
{
    public GameObject PipePrefab;

    private float countdown;
    public float timeDarution;

    private void Awake()
    {
        countdown = timeDarution;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            Instantiate(PipePrefab, new Vector3(10, Random.Range(-2.3f, 3.5f), 0), Quaternion.identity);
            countdown = timeDarution;
        }
    }
}
