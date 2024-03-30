namespace BadCode
{
    public class InvitationSender
    {
        public void SendInvitation(Person person)
        {
            var invitationText = $"Здравствуйте, {person.FullName}! Приглашаем Вас на нашу свадьбу.";
            //var invitationText = $"Здравствуй, {person.FullName}! Приглашаем Вас на нашу свадьбу.";

            Console.WriteLine(invitationText);
            //throw new Exception(invitationText);        
        }
    }
}
