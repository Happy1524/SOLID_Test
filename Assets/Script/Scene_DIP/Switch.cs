using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISwitchable //�������̽� ����.
{
    public bool IsActive { get; } //���� ����
    public void Activate(); //Ȱ�� �Լ�
    public void Deactivate(); //��Ȱ�� �Լ�
}

public class Switch : MonoBehaviour
{
    public ISwitchable client; // ��� ���������� �����ϴ� �� �ƴ϶�, Interface�� ���� ����.

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
