namespace Openlet.Models;

public class LearnCard
{
    public LearnCard(Learn learn, Card card, Pool pool)
    {
        Learn = learn;
        Card = card;
        Pool = pool;
        RepeatedFalse = 0;
    }

    public LearnCard()
    {
        
    }
    
    public int LearnCardId { get; set; }
    
    public Learn Learn { get; set; } = null!;
    public int LearnId { get; set; }
    
    public Card Card { get; set; } = null!;
    public int CardId { get; set; }
    
    public Pool Pool { get; set; }
    
    public int RepeatedFalse { get; set; }

    public int LastCardIndex { get; set; }
}