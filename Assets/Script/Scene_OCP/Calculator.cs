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
                Debug.Log(shape.name + "�� ���̴� " + area + "�Դϴ�.");
            }
            else
            {
                Debug.LogWarning(shape.name + "�� Shape ������Ʈ�� �����ϴ�");
            }
        }
    }


    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }

}
