using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LowLevelCalculator : MonoBehaviour
{

    //게임 오브젝트의 UI컴포넌트에 출력되는 방법
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

        //사각형의 넓이를 구하는 코드
    }

    //public float GetCircleAread(Triangle triangle)
    //{
    //    return triangle.radius * triangle.radius * Mathf.PI;

    //    //원의 넓이를 구하는 코드
    //}
}
