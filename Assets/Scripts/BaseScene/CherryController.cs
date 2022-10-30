using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CherryController : MonoBehaviour
{

    public GameObject cherry;
    private float buffer = 10.0f;
    private float current;
    private Tweener tweener;
    private GameObject clone;
    private float yValue;
    private float timeToTween = 8.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        yValue = randomValue();
        current += Time.deltaTime;
        Debug.Log(current);
        if (current > buffer)
        {
            
            Instantiate(cherry, new Vector3(Random.Range(5.0f, 30.0f), yValue,0.0f), Quaternion.identity);
            current = current - buffer; 
        }
        clone = GameObject.FindGameObjectWithTag("Cherry");
        if (GameObject.FindGameObjectWithTag("Cherry") != null && !tweener.TweenExists(clone.transform))
        {
            Debug.Log("working");
            move();
            if(clone.transform.position.y > 7.50f|| clone.transform.position.y < -38.50f)
            {
                Destroy(clone);
            }
            
        }
        
    }
    
    public void move()
    {
        if (clone.transform.position.y == -32 )
        {
            tweener.AddTween(clone.transform, clone.transform.position, new Vector3(clone.transform.position.x, 8.0f, 0.0f), timeToTween);
           
        }
        else if (clone.transform.position.y == 1)
        {

            tweener.AddTween(clone.transform, clone.transform.position, new Vector3(clone.transform.position.x, -39.0f, 0.0f), timeToTween);
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
