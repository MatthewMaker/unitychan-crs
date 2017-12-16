using UnityEngine;

public class AutoCameraChange : MonoBehaviour {

    [SerializeField]
    CameraSwitcher m_switcher;

    private void OnEnable()
    {
        m_switcher.StartAutoChange();
    }

    private void OnDisable()
    {
        m_switcher.StopAllCoroutines();        
    }
}
