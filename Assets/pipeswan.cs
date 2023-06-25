using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeswan : MonoBehaviour
{
    public GameObject pipe;
    public float timer = 0;
    public float span = 2;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spanpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < span)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spanpipe();
            timer = 0;
        }
    }

    void spanpipe()
    {
        float lowestp = transform.position.y - heightOffset;
        float highestp = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestp,highestp),0), transform.rotation);
    }
}
