using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Card : MonoBehaviour, ICard
{
    public ListCardDeck listCardDeck;
    [SerializeField] private float scaleMaxCard = 1f;
    [SerializeField] private float scaleMinCard = 0;
    [SerializeField] private Vector2 newPoint;
    private float speedApplicationScale = 0.01f;
    private float scaleNowCard = 1;
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
            else
                speedApplicationScale = 0;
        }
    }
     public void Awake()
    {
        scaleNowCard = transform.localScale.x;
    }
    public void Application()
    {
        ScaleNowCard += speedApplicationScale;
        transform.localScale = new Vector3(ScaleNowCard, ScaleNowCard, 1);
    }
    public void MoveToPoint(Vector2 point)
    {
        transform.localPosition = point;
    }
    public void Destroy()
    {
        throw new System.NotImplementedException();
    }

    public void IncreaseCard()
    {
        throw new System.NotImplementedException();
    }
    public void SelectCard()
    {
        transform.AddComponent<MoveToMouse>();
        listCardDeck.SelectCard(gameObject);
    }
    public void ReturnToTheDeck()
    {
        throw new System.NotImplementedException();
    }
    public void Update()
    {
        Application();
    }
}
