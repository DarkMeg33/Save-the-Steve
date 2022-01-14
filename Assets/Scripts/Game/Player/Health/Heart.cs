using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    [SerializeField] private Sprite _sprite;

    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void ChangeSprite()
    {
        _image.overrideSprite = _sprite;
    }
}
