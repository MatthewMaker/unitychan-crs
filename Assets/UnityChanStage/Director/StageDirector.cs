using UnityEngine;
using System.Collections;

public class StageDirector : MonoBehaviour
{
    // Prefabs.
    public GameObject mainCameraRigPrefab;

    // Camera points.
    public Transform[] cameraPoints;

    // Exposed to animator.
    public float overlayIntensity = 1.0f;

    // Objects to be controlled.
    CameraSwitcher mainCameraSwitcher;
    ScreenOverlay[] screenOverlays;
    GameObject[] objectsNeedsActivation;

    void Awake()
    {
        // Instantiate the prefabs.
        var cameraRig = (GameObject)Instantiate(mainCameraRigPrefab);
        mainCameraSwitcher = cameraRig.GetComponentInChildren<CameraSwitcher>();
        screenOverlays = cameraRig.GetComponentsInChildren<ScreenOverlay>();
    }

    void Update()
    {
        foreach (var so in screenOverlays)
        {
            so.intensity = overlayIntensity;
            so.enabled = overlayIntensity > 0.01f;
        }
    }

    public void StartMusic()
    {
        Debug.Log("StartMusic");
    }

    public void ActivateProps()
    {
        Debug.Log("ActivateProps");
    }

    public void SwitchCamera(int index)
    {
        if (mainCameraSwitcher)
            mainCameraSwitcher.ChangePosition(cameraPoints[index], true);
    }

    public void StartAutoCameraChange()
    {
        if (mainCameraSwitcher)
            mainCameraSwitcher.StartAutoChange();
    }

    public void StopAutoCameraChange()
    {
        if (mainCameraSwitcher)
            mainCameraSwitcher.StopAutoChange();
    }

    public void EndPerformance()
    {
        Application.LoadLevel(0);
    }
}
