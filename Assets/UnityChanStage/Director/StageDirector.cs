using UnityEngine;


public class StageDirector : MonoBehaviour
{
    #region ScreenOverlay
    // Objects to be controlled.
    public ScreenOverlay[] screenOverlays;

    // Exposed to animator.
    public float overlayIntensity = 1.0f;

    void Update()
    {
        foreach (var so in screenOverlays)
        {
            so.intensity = overlayIntensity;
            so.enabled = overlayIntensity > 0.01f;
        }
    }
    #endregion

    #region AnimationClip Events
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
        Debug.LogFormat("SwitchCamera: {0}", index);
    }

    public void StartAutoCameraChange()
    {
        Debug.Log("StartAutoCameraChange");
    }

    public void StopAutoCameraChange()
    {
        Debug.Log("StopAutoCameraChange");
    }

    public void EndPerformance()
    {
        Debug.Log("EndPerformance");
    }
    #endregion
}
