using UnityEngine;

public class Settings : MonoBehaviour
{
    [SerializeField] private GameObject _panel;

    public void CloseSettings()
    {
        gameObject.SetActive(false);
        _panel.SetActive(false);
    }
}
