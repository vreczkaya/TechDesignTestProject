using UnityEngine;

public class AnimatedObject : MonoBehaviour
{
    public Sound SoundType;

    private const string _moonTag = "Moon";
    private const string _sunTag = "Sun";
    private const string _starTag = "Star";
    private const string _balloonsTag = "Balloons";

    private void Awake()
    {
        SoundType = gameObject.tag switch
        {
            _moonTag => Sound.MoonSound,
            _sunTag => Sound.SunSound,
            _starTag => Sound.StarsSound,
            _balloonsTag => Sound.BalloonsSound,
            _ => Sound.None
        };
    }
}
