using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISwitchable //인터페이스 생성.
{
    public bool IsActive { get; } //상태 저장
    public void Activate(); //활성 함수
    public void Deactivate(); //비활성 함수
}

public class Switch : MonoBehaviour
{
    public ISwitchable client; // 도어를 직접적으로 연결하는 게 아니라, Interface를 통해 연결.

    public void Toggle()
    {
        if (client.IsActive)
        {
            client.Deactivate();
        }
        else
        {
            client.Activate();
        }
    }


}
