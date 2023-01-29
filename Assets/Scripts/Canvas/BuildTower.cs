using UnityEngine;
public class BuildTower : MonoBehaviour
{
    public Card card;
    private Vector2 startPosMouse;
    [SerializeField] private float timeIncreaseCard = 0.3f;
    private float timer;
    [SerializeField] private float range;
    private bool IncreaseCardBool;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startPosMouse = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
            timer = timeIncreaseCard;
            IncreaseCardBool = false;
        }
        if (Input.GetMouseButtonUp(0) && !IncreaseCardBool)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.TryGetComponent(out BuildCell buildCell) && card != null)
                {
                    print("vidnik buildTower");
                    if (buildCell.SetCardsInPos(card))
                    {
                        print("vidnik DestroyTower");
                        Destroy(card);
                    }
                }
            }
        }
        if (Input.GetMouseButton(0))
        {
            timer -= Time.deltaTime;
            Vector2 NowMousePos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).z);
            if (Vector2.Distance(startPosMouse, NowMousePos) > range)
            {
                timer = timeIncreaseCard;
            }
            if (timer<=0 && !IncreaseCardBool)
            {
                IncreaseCardBool = true;
                card.IncreaseCard();
            }
        }
    }
}
