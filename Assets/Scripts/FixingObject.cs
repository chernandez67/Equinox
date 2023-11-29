using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FixingObject : MonoBehaviour
{
    
    public enum FixingObjectType
    {
        Not,
        Battery,
        Motor,
        Antenna,
        Gear,
        Rock,
        SidePannel,
    }

    public FixingObjectType type;

    public bool isGrabbable;
}
