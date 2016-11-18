using UnityEngine;
using System.Collections;

public class ViveControllers : MonoBehaviour {

    private SteamVR_TrackedObject trackedObj;
    private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }

    private Valve.VR.EVRButtonId trigger = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private bool triggerDown, triggerUp;
    
	void Start () {

        trackedObj = GetComponent<SteamVR_TrackedObject>();
	
	}
	
	void Update () {

        triggerDown = controller.GetPressDown(trigger);
        triggerUp = controller.GetPressUp(trigger);

        if (triggerDown)
        {
            Time.timeScale = 0.1f;
            Debug.LogWarning("TIME IS SLOOWWWWWWWWW");
        }
        if (triggerUp)
        {
            Time.timeScale = 1;
        }



    }
}
