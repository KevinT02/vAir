using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using System;



public class ARTap : MonoBehaviour
{

    //private ARSessionOrigin arOrigin;
    private ARRaycastManager raycastManager;
    private Pose placementPose;
    private bool placementPoseIsValid;
    private bool isObjectPlaced;


    public GameObject positionIndicator;
    public GameObject prefabToPlace;
    public Camera ARCamera;
    public Canvas canvas;


    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }

    void Update()
    {
        if (!isObjectPlaced)
        {
            UpdatePlacementPose();

            if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                PlaceObject();
            }
        }

    }


    private void UpdatePlacementPose()
    {
        var screenCenter = ARCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        raycastManager.Raycast(screenCenter, hits, TrackableType.All);

        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
            var cameraForward = ARCamera.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;

            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
            positionIndicator.SetActive(true);
            positionIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            positionIndicator.SetActive(false);
        }
    }

    private void PlaceObject()
    {
        var spawnedObject = Instantiate(prefabToPlace, placementPose.position, placementPose.rotation);
        RotateManager.GetInstance().SetBuilding(spawnedObject);

        isObjectPlaced = true;
        positionIndicator.SetActive(false);
        canvas.gameObject.SetActive(true);
    }
}
/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using System;



public class ARTap : MonoBehaviour
{

    //private ARSessionOrigin arOrigin;
    private ARRaycastManager raycastManager;
    private Pose placementPose;

    public GameObject positionIndicator;
    public GameObject prefabToPlace;

    private bool placementPoseIsValid;
    private bool isObjectPlaced;


    
    public Camera ARCamera;
    public Canvas canvas;



  
  
    private void Awake()
    {
        raycastManager = GetComponent<ARRaycastManager>();
    }


    void Update()
    {

        if (!isObjectPlaced)
        {
            UpdatePlacementPose();

            if (placementPoseIsValid && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                PlaceObject();
            }
        }

    }


    private void UpdatePlacementPose()
    {
        var screenCenter = ARCamera.ViewportToScreenPoint(new Vector3(0.5f, 0.5f));
        var hits = new List<ARRaycastHit>();

        raycastManager.Raycast(screenCenter, hits, TrackableType.All);

        placementPoseIsValid = hits.Count > 0;

        if (placementPoseIsValid)
        {
            placementPose = hits[0].pose;
            var cameraForward = ARCamera.transform.forward;
            var cameraBearing = new Vector3(cameraForward.x, 0, cameraForward.z).normalized;

            placementPose.rotation = Quaternion.LookRotation(cameraBearing);
            positionIndicator.SetActive(true);
            positionIndicator.transform.SetPositionAndRotation(placementPose.position, placementPose.rotation);
        }
        else
        {
            positionIndicator.SetActive(false);
        }
    }

    private void PlaceObject()
    {
        var spawnedObject = Instantiate(prefabToPlace, placementPose.position, placementPose.rotation);
        RotateManager.GetInstance().SetBuilding(spawnedObject);

        isObjectPlaced = true;
        positionIndicator.SetActive(false);
        canvas.gameObject.SetActive(true);
    }
}




*/