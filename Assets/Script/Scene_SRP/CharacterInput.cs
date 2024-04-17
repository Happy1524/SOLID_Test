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
        //normalized 는 입력 벡터를 단위 벡터로 정규화하여 반환해줌. 단위벡터는 방향을 나타내는 벡터임.
        //또한 일관성있는 속도와 힘을 적용하기 위해 사용됨.
    }
}