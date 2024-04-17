using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowLevelCalculator : MonoBehaviour
{

    //���� ������Ʈ�� UI������Ʈ�� ��µǴ� ���
    //public Text outputText;


    private void Start()
    {
        Rectangle rectangle = FindObjectOfType<Rectangle>();

        if (rectangle != null)
        {
            float rectangleArea = GetRectangleArea(rectangle);
            //outputText.text = rectangleArea.ToString();
            Debug.Log("Low Level Rectangle Area:" + rectangleArea);
        }
        else
        {
            Debug.LogError("Rectangle not found");
        }
    }


    public float GetRectangleArea(Rectangle rectangle)
    {
        return rectangle.width * rectangle.height;

        //�簢���� ���̸� ���ϴ� �ڵ�
    }

    //public float GetCircleAread(Triangle triangle)
    //{
    //    return triangle.radius * triangle.radius * Mathf.PI;

    //    //���� ���̸� ���ϴ� �ڵ�
    //}
}
