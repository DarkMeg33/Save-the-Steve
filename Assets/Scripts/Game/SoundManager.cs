using UnityEngine;
using UnityEngine.Events;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioClip _creeperExplosionSound;
    [SerializeField] private AudioClip _creeperKillSound;
    [SerializeField] private AudioClip _zombieKillSound;
    [SerializeField] private AudioClip _steveKillSound;

    [SerializeField] private AudioSource _audioSource;

    public static UnityEvent OnCreeperKilled = new UnityEvent();
    public static UnityEvent OnCreeperExplosion = new UnityEvent();
    public static UnityEvent OnZombieKilled = new UnityEvent();
    public static UnityEvent OnSteveKilled = new UnityEvent();

    private void Awake()
    {
        OnCreeperExplosion.AddListener(PlayCreeperExplosionSound);
        OnCreeperKilled.AddListener(PlayCreeperKillSound);
        OnZombieKilled.AddListener(PlayZombieKillSound);
        OnSteveKilled.AddListener(PlaySteveKillSound);
    }

    private void PlayCreeperExplosionSound()
    {
        _audioSource.clip = _creeperExplosionSound;
        _audioSource.Play();
    }

    private void PlayCreeperKillSound()
    {
        _audioSource.clip = _creeperKillSound;
        _audioSource.Play();
    }

    private void PlayZombieKillSound()
    {
        _audioSource.clip = _zombieKillSound;
        _audioSource.Play();
    }

    private void PlaySteveKillSound()
    {
        _audioSource.clip = _steveKillSound;
        _audioSource.Play();
    }
}
