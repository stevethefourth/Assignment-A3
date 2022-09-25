using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    [SerializeField] private Animator direction;
    private Tweener tweener;
    

    

    // Start is called before the first frame update
    void Start()
    {
        tweener = gameObject.GetComponent<Tweener>();
        


    }

    // Update is called once per frame
    void Update()
    {


        if (item.transform.position.x == 5.48f && item.transform.position.y == -1.53f)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(10.51f, -1.53f, 0.0f), 3.0f);
            direction.SetTrigger("D");

        }

        else if (item.transform.position.x == 10.51f && item.transform.position.y == -1.53f)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(10.51f, -5.4f, 0.0f), 3.0f);
            direction.SetTrigger("S");
        }


        if (item.transform.position.x == 10.51f && item.transform.position.y == -5.4f)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(5.48f, -5.4f, 0.0f), 3.0f);
            direction.SetTrigger("A");

        }


        else if (item.transform.position.x == 5.48f && item.transform.position.y == -5.4f)
        {
            tweener.AddTween(item.transform, item.transform.position, new Vector3(5.48f, -1.53f, 0.0f), 3.0f);
            direction.SetTrigger("W");
        }
       


    }
}