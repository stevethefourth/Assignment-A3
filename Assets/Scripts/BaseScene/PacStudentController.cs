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
    public Sprite background;
    public Sprite pellets;
    public Sprite powerPellets;
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
           
            lastinput = "left";

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
           
            lastinput = "up";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            
            lastinput = "right";
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
           
            lastinput = "down";
        }
        if (canWalk(lastinput) == true)
        {
            
            currentinput = lastinput;
            switch (currentinput)
            {
                case "left":
                    m_animator.ResetTrigger("B");
                    m_animator.SetTrigger("A");
                    break;
                case "right":
                    m_animator.ResetTrigger("B");
                    m_animator.SetTrigger("D");
                    break;
                case "up":
                    m_animator.ResetTrigger("B");
                    m_animator.SetTrigger("W");
                    break;
                case "down":
                    m_animator.ResetTrigger("B");
                    m_animator.SetTrigger("S");
                    break;
                default:
                    break;

            }
            if (!tweener.TweenExists(transform))
            {
                tweener.AddTween(transform, transform.position, nextTile(), 0.5f);

            }
        }
        if(canWalk(lastinput) == false)
        {
            if(canWalk(currentinput) == true)
            {
                if (!tweener.TweenExists(transform))
                {
                    tweener.AddTween(transform, transform.position, nextTile(), 0.5f);

                }
            }
            else
            {
                m_animator.SetTrigger("B");
            }
          
        }

       
    }
    public bool canWalk(string direction)
    {
        Vector3Int gridposition = currentTilemap.WorldToCell(transform.position);
        switch (direction)
        {
            case "left": gridposition = currentTilemap.WorldToCell(transform.position + Left);
                if (currentTilemap.GetSprite(gridposition) == background || currentTilemap.GetSprite(gridposition) == pellets || currentTilemap.GetSprite(gridposition) == powerPellets)
                    return true;
                return false;
            case "right": gridposition = currentTilemap.WorldToCell(transform.position + Right);
                if (currentTilemap.GetSprite(gridposition) == background || currentTilemap.GetSprite(gridposition) == pellets || currentTilemap.GetSprite(gridposition) == powerPellets)
                    return true;
                return false;
            case "up":  gridposition = currentTilemap.WorldToCell(transform.position + Up);
                if (currentTilemap.GetSprite(gridposition) == background || currentTilemap.GetSprite(gridposition) == pellets || currentTilemap.GetSprite(gridposition) == powerPellets)
                    return true;
                return false;
            case "down": gridposition = currentTilemap.WorldToCell(transform.position + Down);
                if (currentTilemap.GetSprite(gridposition) == background || currentTilemap.GetSprite(gridposition) == pellets || currentTilemap.GetSprite(gridposition) == powerPellets)
                    return true;
                return false;
            default:
                break;

        }
        return false;
    }
    public Vector3 nextTile()
    {
        Vector3Int gridposition = currentTilemap.WorldToCell(transform.position);
        Vector3 center;
        switch (currentinput)
        {
            case "left": gridposition = currentTilemap.WorldToCell(transform.position + Left);
                center = currentTilemap.GetCellCenterWorld(gridposition); 
                return center;
            case "right":
                gridposition = currentTilemap.WorldToCell(transform.position + Right);
                center = currentTilemap.GetCellCenterWorld(gridposition);
                return center;
            case "up":
                 gridposition = currentTilemap.WorldToCell(transform.position + Up);
                center = currentTilemap.GetCellCenterWorld(gridposition);
                return center;
            case "down":
                 gridposition = currentTilemap.WorldToCell(transform.position + Down);
                center = currentTilemap.GetCellCenterWorld(gridposition);
                return center;
            default:
                break;
                
        }

        center = currentTilemap.GetCellCenterWorld(gridposition);
        return center;



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
