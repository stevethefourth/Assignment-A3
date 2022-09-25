using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacStudentMovement : MonoBehaviour
{
    Animator m_animator;
    // Start is called before the first frame update
    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_animator.SetTrigger("A");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            m_animator.SetTrigger("W");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_animator.SetTrigger("D");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_animator.SetTrigger("S");
        }
    }
}
