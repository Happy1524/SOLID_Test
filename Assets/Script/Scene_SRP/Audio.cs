using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource footstepSound; // 발걸음 소리를 재생하기 위한 AudioSource
    private Movement movement;

    private void Start()
    {
        movement = GetComponent<Movement>();

        // Movement 스크립트의 이벤트에 구독
        movement.OnCharacterMove += HandleCharacterMove;
    }

    private void HandleCharacterMove(Vector3 moveDirection)
    {
        // 발걸음 소리 재생
        if (!footstepSound.isPlaying)
        {
            footstepSound.Play();
        }
    }
}
