using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Card : MonoBehaviour, ICard, ICards
{
    public enum ModeCard
    {
        ITower,
        IBonusTowers
    }
    public ListCardDeck listCardDeck;
    [SerializeField] private float scaleMaxCard = 1f;
    [SerializeField] private float scaleMinCard = 0;
    [SerializeField] private Vector2 newPoint;
    [SerializeField]private float speedApplication = 0.01f;
    private float speedApplicationScale = 0.01f;
    private float scaleNowCard = 1;
    public LineRender lineRender;
    public BuildTower buildTower;
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

    public int IdCards { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public ICards.ModeCard selfMode { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Awake()
    {
       // selfMode = ModeCard.ITower;
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
        lineRender.enabled = false;
        listCardDeck.SelectCard(gameObject);
         transform.localPosition = new Vector2(0, 0);
         speedApplicationScale = speedApplication;
         scaleMaxCard = 3;
    }
    public void DecreaseCard()
    {
        lineRender.enabled = false;
        listCardDeck.ReturnToDeck(gameObject);
        speedApplicationScale = -speedApplication;
        scaleMinCard = 1;
    }
    public void SelectCard()
    {
        //transform.AddComponent<MoveToMouse>();
        lineRender.enabled = true;
        buildTower.card = this;
        //listCardDeck.SelectCard(gameObject);
    }
    public void ReturnToTheDeck()
    {
        throw new System.NotImplementedException();
    }
    public void FixedUpdate()
    {
        Application();
    }

    
}
