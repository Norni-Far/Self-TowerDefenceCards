using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICard
{
    public void IncreaseCard();//увеличение выбранной карты
    public void MoveToPoint(Vector2 point);//движение в точку
    public void ReturnToTheDeck();//вернуться в колоду
    public void Application();//примменение
    public void Destroy();//уничтожение

}
