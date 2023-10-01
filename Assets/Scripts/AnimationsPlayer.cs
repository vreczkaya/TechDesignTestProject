using UnityEngine;

public class AnimationsPlayer : MonoBehaviour
{
    [SerializeField]
    private bool _shouldCallButton = false;
    [SerializeField]
    private bool _isAnimated = true;

    [SerializeField]
    private GameObject _transitionButton;

    [SerializeField]
    private Animator _animator;

    [SerializeField]
    private SoundManager _soundManager;

    [SerializeField]
    private AnimatedObject _animatedObject;

    private void OnMouseDown()
    {
        if (_isAnimated)
        {
            _animator.SetBool("isPlaying", true);
            _soundManager.PlaySound(_animatedObject.SoundType);
        }

        if (_shouldCallButton)
        {
            _transitionButton.SetActive(true);
        }
    }

    private void OnMouseUp()
    {
        if (_isAnimated)
        {
            _animator.SetBool("isPlaying", false);
        }
    }
}
