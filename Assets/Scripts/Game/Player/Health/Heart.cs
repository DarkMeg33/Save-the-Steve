using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;

    public void ChangeSprite()
    {
        GetComponent<Image>().overrideSprite = _sprite;
    }
}
