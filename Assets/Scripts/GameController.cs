using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Button draw;
    [SerializeField] private Button hit;
    [SerializeField] private Button stay;
    [SerializeField] private Sprite[] cards = new Sprite[52];
    [SerializeField] private Image[] playerCards = new Image[5];
    [SerializeField] private Image[] compCards = new Image[5];
    [SerializeField] private Image hiddenCompCard;
    private int playerCardCounter = 2;

    // Start is called before the first frame update
    void Start()
    {
        InitialHUD();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlayerCards()
    {
        int randNum = Random.Range(0, cards.Length);
        playerCards[0].sprite = cards[randNum];
        int randNumTwo = Random.Range(0, cards.Length);
        playerCards[1].sprite = cards[randNumTwo];
    }

    public void OnDrawCards()
    {
        HumanPlayer human = new HumanPlayer();
        CompPlayer comp = new CompPlayer();
        draw.gameObject.SetActive(false);
        hit.gameObject.SetActive(true);
        stay.gameObject.SetActive(true);
        playerCards[0].gameObject.SetActive(true);
        playerCards[1].gameObject.SetActive(true);
        PlayerCards();
    }

    public void OnHitButton()
    {
        int randNum = Random.Range(0, cards.Length);
        playerCards[playerCardCounter].sprite = cards[randNum];
        playerCards[playerCardCounter].gameObject.SetActive(true);
        playerCardCounter++;
    }

    void InitialHUD()
    {
        hit.gameObject.SetActive(false);
        stay.gameObject.SetActive(false);
        hiddenCompCard.gameObject.SetActive(false);
        for(int i = 0; i < playerCards.Length; i++)
        {
            playerCards[i].gameObject.SetActive(false);
            compCards[i].gameObject.SetActive(false);
        }
    }
}
