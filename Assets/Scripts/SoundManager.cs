using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [SerializeField]
    private AudioSource[] _audioSources;

    public void PlaySound(Sound sound)
    {
        if (sound == Sound.None) return;
        _audioSources[(int)sound].GetComponent<AudioSource>().Play();
    }
}
