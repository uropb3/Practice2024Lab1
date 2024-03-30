using BadCode;
//using GoodCode;

internal class Program
{
    /* Условие:
     * Необходимо продемонстрировать соблюдение и нарушение принципа единственной ответственности (Single Responsibility Principle, SRP) 
     * на примере программы, выполняющей одну и ту же задачу. */

    private static void Main(string[] args)
    {
        var person = new Person
        {
            FirstName = "Игорь",
            LastName = "Полеводин",
            Patronymic = "Юрьевич"
        };

        var invitationSender = new InvitationSender();
        invitationSender.SendInvitation(person);
    }
}