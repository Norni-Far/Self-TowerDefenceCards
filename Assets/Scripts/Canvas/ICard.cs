using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard
{
    public void IncreaseCard();//���������� ��������� �����
    public void MoveToPoint(Vector2 point);//�������� � �����
    public void ReturnToTheDeck();//��������� � ������
    public void Application();//�����������
    public void Destroy();//�����������

}
