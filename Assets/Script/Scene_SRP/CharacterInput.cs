using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInput : MonoBehaviour
{
    public Vector3 GetMovementInput()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        return new Vector3(horizontalInput, 0f, verticalInput).normalized;
        //normalized �� �Է� ���͸� ���� ���ͷ� ����ȭ�Ͽ� ��ȯ����. �������ʹ� ������ ��Ÿ���� ������.
        //���� �ϰ����ִ� �ӵ��� ���� �����ϱ� ���� ����.
    }
}