using UnityEngine;
using Cinemachine;
using System;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwitchBoundingShape();
    }

    // Switch the collider that cinemachine uses to define the edges of the screen
    // between PersistentScene and Farm scene for example so we can just define a single ConfinerBoundary game object.
    private void SwitchBoundingShape()
    {
        // Get the polygon collider on the 'boundsconfiner', this bounds the camera
        // .GetComponent<PolygonCollider2D>(); <= get the component and save it to the variable
        PolygonCollider2D polygonCollider2D = GameObject
            .FindGameObjectWithTag(Tags.BoundsConfiner)
            .GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();

        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        // since confiner bounds have changed, we need to clear the cache

        cinemachineConfiner.InvalidatePathCache();
    }
}
