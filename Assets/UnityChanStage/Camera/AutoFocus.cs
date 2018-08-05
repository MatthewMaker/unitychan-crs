using UnityEngine;

//using UnityEngine.PostProcessing;

[ExecuteInEditMode]
public class AutoFocus : MonoBehaviour
{
#if UNITY_POST_PROCESSING_STACK_V1
    [SerializeField]
    PostProcessingBehaviour m_postprocessing;
    Po
    [SerializeField]
    GameObject m_target;

    private void Reset()
    {
        m_postprocessing = GetComponent<PostProcessingBehaviour>();
    }

    void Update()
    {
        var settings = m_postprocessing.profile.depthOfField.settings;
        m_postprocessing.profile.depthOfField.settings = new DepthOfFieldModel.Settings
        {
            focusDistance = (m_target.transform.position - transform.position).magnitude,
            aperture = settings.aperture,
            focalLength = settings.focalLength,
            kernelSize = settings.kernelSize,
            useCameraFov = settings.useCameraFov,
        };
    }
#endif
}
