using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrustumDrawer : MonoBehaviour {

    Camera firstPersonCamera;

	// Use this for initialization
	void Awake() 
    {
        firstPersonCamera = gameObject.GetComponent<Camera>();
	}

    private void Update()
    {
        OnDrawGizmos();
    }

    // Update is called once per frame
    private void OnDrawGizmos()
    {
        if(firstPersonCamera != null)
        {
            Gizmos.color = Color.cyan;
            Gizmos.matrix = firstPersonCamera.transform.localToWorldMatrix;
            Gizmos.DrawFrustum(firstPersonCamera.transform.position, firstPersonCamera.fieldOfView, firstPersonCamera.farClipPlane, firstPersonCamera.nearClipPlane, firstPersonCamera.aspect);
        }
    }

    private void OnDestroy()
    {
        firstPersonCamera = null;
    }
}
