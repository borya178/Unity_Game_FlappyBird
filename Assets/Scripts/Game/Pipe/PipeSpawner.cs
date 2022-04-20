using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField]
    private float _maxTime;

    [SerializeField]
    private float _heigth;

    [SerializeField]
    private GameObject _pipe;

    private float timer = 0;

    private void Start()
    {
        GameObject newpipe = Instantiate(_pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-_heigth, _heigth), 0);
    }

    private void Update()
    {
        if (timer > _maxTime)
        {

            GameObject newpipe = Instantiate(_pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-_heigth, _heigth), 0);
            Destroy(newpipe, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}
