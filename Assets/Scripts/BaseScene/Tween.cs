using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 EndPos { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }


    public Tween(Transform newTarget, Vector3 newStartPos, Vector3 newEndPos, float newStartTime, float newDuration)
    {
        Target = newTarget;
        StartPos = newStartPos;
        EndPos = newEndPos;
        StartTime = newStartTime;
        Duration = newDuration;
    }



}
