using System;
using UnityEngine;

public class CubeInteractable : MonoBehaviour, IInteractable
{
    public bool _Interacted = false;

    public void OnRayHit()
    {
        _Interacted = true;
        GetComponent<Renderer>().material.color = Color.red;
    }

}

