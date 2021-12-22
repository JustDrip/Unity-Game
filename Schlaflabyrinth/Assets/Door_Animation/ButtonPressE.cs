using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressE : MonoBehaviour
{
    [SerializeField] private int rayLength = 5;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    private TriggerDoorController raycastedObj;

    [SerializeField] private KeyCode OpenDoorKey = KeyCode.E;

    [SerializeField] private Image crosshair = null;

    private bool isCrosshairAktive;
    private bool doOnce;

    private const string interactableTag ="DoorButton";


    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if (Physics.Raycast(transform.position, fwd,out hit, rayLength, mask))
        {
            if (hit.collider.CompareTag(interactableTag))
            {
                if (!doOnce)
                {
                    raycastedObj = hit.collider.gameObject.GetComponent<TriggerDoorController>();
                    CrosshairChange(true);

                }
                isCrosshairAktive = true;
                doOnce = true;

                if (Input.GetKey(OpenDoorKey))
                {
                    raycastedObj.PlayAnimation();
                }
            }
        }

        else
        {
            if (isCrosshairAktive)
            {
                CrosshairChange(false);
                doOnce = false;
            }
        }

    }

    void CrosshairChange(bool on)
    {
        if(on && !doOnce)
        {
            crosshair.color = Color.red;
        }
        else
        {
            crosshair.color = Color.white;
            isCrosshairAktive = false;
        }
    }






}
