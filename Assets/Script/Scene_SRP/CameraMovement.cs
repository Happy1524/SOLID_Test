using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; // MainCharacter를 가리키는 Transform 컴포넌트
    public float mouseSensitivity = 100f; // 마우스 감도

    private float verticalRotation = 0f; // 수직 회전 각도

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // 마우스 커서 숨기기
    }

    private void Update()
    {
        // 마우스 입력 처리
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // 수평 회전은 MainCharacter의 y축 방향으로
        player.Rotate(Vector3.up * mouseX);

        // 수직 회전은 카메라의 로컬 x축 방향으로
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f); // 수직 회전 각도 제한

        // 카메라의 회전 적용
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // 카메라의 위치를 MainCharacter의 위치로 일치시킴
        transform.position = player.position;
    }
}
