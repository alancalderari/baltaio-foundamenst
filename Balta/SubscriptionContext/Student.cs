using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext;

public class Student : Base
{
    public string Name { get; set; }
    public string Email { get; set; }
    public User User { get; set; }
    public IList<Subscription> Subscriptions { get; set; }

    public void CreateSubscription(Subscription subscription)
    {
        if (isPremium)
        {
            AddNotification(new Notification("Premium","Aluno já tem assinatura ativa!"));
            return;
        }
        
        Subscriptions.Add(subscription);
    }
    
    public bool isPremium => Subscriptions.Any(x => !x.isInactive);
}