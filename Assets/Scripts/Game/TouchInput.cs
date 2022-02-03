using UnityEngine;

public class TouchInput : MonoBehaviour
{
    private void Update()
    {
        foreach (var touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);

                if (Physics.Raycast(ray, out RaycastHit hitInfo))
                {
                    if (hitInfo.collider.gameObject.TryGetComponent(out Enemy enemy))
                    {
                        enemy.Remove();
                    }
                }
            }
        }
    }
}
