using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public event Action<Vector3> OnCharacterMove; // ĳ���Ͱ� ������ �� �߻��ϴ� �̺�Ʈ

    public float moveSpeed = 5f;
    private CharacterInput characterInput;

    private void Start()
    {
        characterInput = GetComponent<CharacterInput>();
    }

    private void Update()
    {
        Vector3 moveDirection = characterInput.GetMovementInput(); // ĳ���� �Է°��� moveDirection�� ����

        // ĳ���Ͱ� �����̴� ��쿡�� �̺�Ʈ �߻�
        if (moveDirection != Vector3.zero)
        {
            OnCharacterMove?.Invoke(moveDirection); // �̺�Ʈ �߻�
        }

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime); // ������Ʈ�� ��ġ �̵�
    }
}
