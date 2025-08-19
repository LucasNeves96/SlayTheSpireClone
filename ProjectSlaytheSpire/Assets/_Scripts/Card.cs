using System;
using UnityEngine;

public class Card
{
    public String Title;
    public String Description;
    public int Mana;
    public Sprite Image;
    private readonly CardData cardData;
    public Card(CardData cardData)
    {
        this.cardData = cardData;
        this.Title = cardData.Title;
        this.Description = cardData.Description;
        this.Mana = cardData.Mana;
        this.Image = cardData.Image;
    }

}
