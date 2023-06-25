namespace Balta.SubscriptionContext;

public class Subscription
{
    public Plan Plan { get; set; }
    public DateTime? EndDate { get; set; }
    public bool isInactive => EndDate <= DateTime.Now;
}