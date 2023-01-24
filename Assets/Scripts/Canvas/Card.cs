using Unity.VisualScripting;
using UnityEngine;

public class Card : MonoBehaviour, ICard
{
    public float scaleNowCard = 1;
    private float ScaleNowCard
    {
        get
        {
            return scaleNowCard;
        }
        set
        {
            if (value < scaleMaxCard && value > scaleMinCard)
                scaleNowCard = value;
        }
    }
    private float speedApplicationScale = 0.01f;
    [SerializeField] private float scaleMaxCard = 1.5f;
    [SerializeField] private float scaleMinCard = 1;
    [SerializeField] private Vector2 newPoint;
    public void Application()
    {
        ScaleNowCard += speedApplicationScale;
        transform.localScale = new Vector3(ScaleNowCard, ScaleNowCard, 1);
    }
    public void MoveToPoint(Vector2 point)
    {
        transform.position = Vector2.MoveTowards(transform.position, point, int.MaxValue);
    }
    public void Destroy()
    {
        throw new System.NotImplementedException();
    }

    public void IncreaseCard()
    {
        throw new System.NotImplementedException();
    }

    public void ReturnToTheDeck()
    {
        throw new System.NotImplementedException();
    }
    public void Update()
    {
        Application();
        MoveToPoint(newPoint);
    }
}
