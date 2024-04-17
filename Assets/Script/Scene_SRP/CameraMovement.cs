using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; // MainCharacter�� ����Ű�� Transform ������Ʈ
    public float mouseSensitivity = 100f; // ���콺 ����

    private float verticalRotation = 0f; // ���� ȸ�� ����

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // ���콺 Ŀ�� �����
    }

    private void Update()
    {
        // ���콺 �Է� ó��
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // ���� ȸ���� MainCharacter�� y�� ��������
        player.Rotate(Vector3.up * mouseX);

        // ���� ȸ���� ī�޶��� ���� x�� ��������
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // ���� ȸ�� ���� ����

        // ī�޶��� ȸ�� ����
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // ī�޶��� ��ġ�� MainCharacter�� ��ġ�� ��ġ��Ŵ
        transform.position = player.position;
    }
}
