using UnityEngine;

public class CameraPosition : MonoBehaviour {

    [SerializeField]
    CameraSwitcher m_switcher;

    private void OnEnable()
    {
        m_switcher.ChangePosition(transform);
    }
}
