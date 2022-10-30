using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PacStudentController : MonoBehaviour
{
    [SerializeField]
    private Tilemap[] tiles;
    private Tilemap currentTilemap;
    Animator m_animator;
    Tweener tweener;
    private string lastinput = "";
    private string currentinput = "";

    private static Vector3Int Left = new Vector3Int(-1, 0, 0), Right = new Vector3Int(1, 0, 0), Up = new Vector3Int(0, 1, 0), Down = new Vector3Int(0, -1, 0);
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
        tweener = GetComponent<Tweener>();

    }

    // Update is called once per frame
    void Update()
    {
        currentTilemap = CheckTileMap();
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_animator.SetTrigger("A");
            lastinput = "left";

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_animator.SetTrigger("W");
            lastinput = "up";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_animator.SetTrigger("D");
            lastinput = "right";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_animator.SetTrigger("S");
            lastinput = "down";
        }
        
        //if (!tweener.TweenExists())
        //{
           //tweener.AddTween(, , , );
            
       // }
    }
    private Tilemap CheckTileMap()
    {
        for(int i = 0; i < tiles.Length;i++ )
        {
            Vector3Int gridposition = tiles[i].WorldToCell(transform.position);
            if (tiles[0].HasTile(gridposition))
            {
                Debug.Log(i);
                return tiles[i];

            }
        }
        Debug.Log("Empty");
        return null;
    }

}
