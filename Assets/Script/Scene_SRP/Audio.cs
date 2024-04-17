using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource footstepSound; // �߰��� �Ҹ��� ����ϱ� ���� AudioSource
    private Movement movement;

    private void Start()
    {
        movement = GetComponent<Movement>();

        // Movement ��ũ��Ʈ�� �̺�Ʈ�� ����
        movement.OnCharacterMove += HandleCharacterMove;
    }

    private void HandleCharacterMove(Vector3 moveDirection)
    {
        // �߰��� �Ҹ� ���
        if (!footstepSound.isPlaying)
        {
            footstepSound.Play();
        }
    }
}
