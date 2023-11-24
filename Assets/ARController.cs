using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARController : MonoBehaviour
{
    public GameObject MyObject;
    public ARRaycastManager RaycastManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        //{
        //    List<ARRaycastHit> touches = new List<ARRaycastHit>();

        //    RaycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes);

        //    if (touches.Count > 0)
        //        GameObject.Instantiate(MyObject, touches[0].pose.position, touches[0].pose.rotation);
        //}

        if (Input.touchCount == 0)
            return;
        List<ARRaycastHit> touches = new List<ARRaycastHit>();
        if (RaycastManager.Raycast(Input.GetTouch(0).position, touches, UnityEngine.XR.ARSubsystems.TrackableType.Planes))
        {
            var hitPose = touches[0].pose;

            if (MyObject == null)
            {
                MyObject = Instantiate(MyObject, hitPose.position, hitPose.rotation);
            }

            else
            {
                MyObject.transform.position = hitPose.position;
                MyObject.transform.rotation = hitPose.rotation;
            }
        }
    }
}
