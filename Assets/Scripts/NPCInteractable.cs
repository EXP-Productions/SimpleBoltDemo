using System;
using UnityEngine;
using PixelCrushers.DialogueSystem;

public class NPCInteractable : MonoBehaviour, IInteractable
{
    public DialogueSystemTrigger _Trigger;
    public void OnRayHit()
    {
        _Trigger.OnUse();
    }
}

