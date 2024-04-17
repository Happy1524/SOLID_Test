using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField]
    private GameObject[] gameObjects;

    private void Start()
    {
        foreach (GameObject shapeObject in gameObjects)
        {
            Shape shape = shapeObject.GetComponent<Shape>();

            if(shape != null)
            {
                float area = GetArea(shape);
                Debug.Log(shape.name + "의 넓이는 " + area + "입니다.");
            }
            else
            {
                Debug.LogWarning(shape.name + "에 Shape 컴포넌트가 없습니다");
            }
        }
    }


    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }

}
