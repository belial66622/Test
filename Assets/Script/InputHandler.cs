using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;
    [SerializeField]private LayerMask layer;
    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastObject(Input.mousePosition);
        }
    }

    private void RaycastObject(Vector2 screenPosition)
    {
        Vector2 worldPosition = _mainCamera.ScreenToWorldPoint(screenPosition);
        var hit = Physics2D.Raycast(worldPosition, Vector2.zero,Mathf.Infinity,layer);
        if (hit.collider != null)
        { if (hit.collider.transform.TryGetComponent(out Deck deck))
            {
                deck.TakeTopCard();
            }

            else if (hit.collider.transform.TryGetComponent(out Trash trash))
            {
                trash.SeeCard();
            }
        }
    }
}

/*
 * 
if (Physics.Raycast(transform.position, lastInteractionDir, out RaycastHit raycastHit, interactDistance, counterLayerMask))
{
    if (raycastHit.transform.TryGetComponent(out ClearCounter clearCounter))
    {
        if (clearCounter != selectedCounter)
        {
            //HasClearCounter
            selectedCounter = clearCounter;
        }
    }
    else
        selectedCounter = null;
}
else
{
    selectedCounter = null;
}
Debug.Log(selectedCounter);

 */