using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public event Action<Vector3> OnCharacterMove; // 캐릭터가 움직일 때 발생하는 이벤트

    public float moveSpeed = 5f;
    private CharacterInput characterInput;

    private void Start()
    {
        characterInput = GetComponent<CharacterInput>();
    }

    private void Update()
    {
        Vector3 moveDirection = characterInput.GetMovementInput(); // 캐릭터 입력값을 moveDirection에 저장

        // 캐릭터가 움직이는 경우에만 이벤트 발생
        if (moveDirection != Vector3.zero)
        {
            OnCharacterMove?.Invoke(moveDirection); // 이벤트 발생
        }

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime); // 오브젝트의 위치 이동
    }
}
