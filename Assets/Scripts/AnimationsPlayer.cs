using UnityEngine;

public class AnimationsPlayer : MonoBehaviour
{
    [SerializeField]
    private bool _shouldCallButton = false;
    [SerializeField]
    private GameObject _transitionButton;
    [SerializeField]
    private Animator _animator;

    private void Start()
    {
        //_animator = GetComponent<Animator>();

        //if (_animator == null)
        //{
        //    _animator = GetComponentInParent<Animator>();
        //}
    }

    private void OnMouseDown()
    {
        _animator.SetBool("isPlaying", true);

        if (_shouldCallButton )
        {
            _transitionButton.SetActive(true);
        }
    }

    private void OnMouseUp()
    {
        _animator.SetBool("isPlaying", false);
    }
}
