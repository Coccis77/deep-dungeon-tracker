namespace DeepDungeonTracker;

public class FloorEffect
{
    public bool IsPomanderOfAffluenceUsed { get; set; }

    public bool IsPomanderOfFlightUsed { get; set; }

    public bool IsPomanderOfAlterationUsed { get; set; }
    
    public bool IsPomanderOfDevotionUsed { get; set; }
    
    public VotiveEffect? NextFloorVotiveEffect { get; set; }

    public bool ShowPomanderOfSafety { get; set; }

    public bool ShowPomanderOfAffluence { get; set; }

    public bool ShowPomanderOfFlight { get; set; }

    public bool ShowPomanderOfAlteration { get; set; }
    
    public bool ShowPomanderOfDevotion { get; set; }
    
}