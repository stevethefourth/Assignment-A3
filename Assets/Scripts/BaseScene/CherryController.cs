using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CherryController : MonoBehaviour
{

    public GameObject cherry;
    private float buffer = 10.0f;
    private float current;
    private float timeToLerp = 8.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        current += Time.deltaTime;
        Debug.Log(current);
        if (current > buffer)
        {
            
            Instantiate(cherry, new Vector3(Random.Range(5.0f, 30.0f), randomValue(),0.0f), Quaternion.identity);
            current = current - buffer; 
        }
        if(GameObject.FindGameObjectsWithTag("Cherry") != null)
        {
            move();
            offScreen();
        }
        
    }
    public void offScreen()
    {
        if(cherry.transform.position.y == 2.0f)
        {
            Destroy(gameObject);
        }
        if (cherry.transform.position.y == -33.0f)
        {
            Destroy(gameObject);
        }
    }
    public void move()
    {
        if (cherry.transform.position.y == -32 )
        {
            cherry.transform.position = Vector3.Lerp(cherry.transform.position, new Vector3(cherry.transform.position.x,2.0f,0.0f), timeToLerp);
        }
        else if (cherry.transform.position.y == 1)
        {
            cherry.transform.position = Vector3.Lerp(cherry.transform.position, new Vector3(cherry.transform.position.x, -33.0f, 0.0f), timeToLerp);
        }
    }
    public float randomValue()
    {
        var val = Random.Range(0.0f, 1.0f);
        if (val < 0.5f)
        {
            return  1;
        }
        
           return  -32;
        
    }
    
}
