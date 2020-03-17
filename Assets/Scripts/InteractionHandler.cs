using System;
using UnityEngine;

public class InteractionHandler : MonoBehaviour
{
    public KeyCode _InteractionKey;
    public Transform _CamTransform;

    private void Update()
    {
        if(Input.GetKeyDown(_InteractionKey))
        {
            RaycastHit hit;
            if (Physics.Raycast(_CamTransform.position, Vector3.forward, out hit, 100f))
            {
                IInteractable hitInteractable = hit.collider.gameObject.GetComponent<IInteractable>();
                if(hitInteractable != null)
                {
                    hitInteractable.OnRayHit();
                }
            }
        }
    }
}

