using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CherryController : MonoBehaviour
{

    public GameObject cherry;
    private float buffer = 10.0f;
    private float yValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var val = Random.Range(0.0f,1.0f);
        if(val < 0.5f)
        {
            yValue = 0;
        }
        else
        {
            yValue = 31;
        }
        float current =+ Time.deltaTime;
        if (buffer < current)
        {
            buffer = +current;
            Instantiate(cherry, new Vector3(Random.Range(5.0f, 30.0f), yValue,0.0f), Quaternion.identity);
        }
        
    }
    
}
