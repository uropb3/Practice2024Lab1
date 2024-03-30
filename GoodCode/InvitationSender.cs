namespace GoodCode
{
    public class InvitationSender
    {
        public void SendInvitation(Person person)
        {
            var invitationTextGenerator = new InvitationTextGenerator();
            var invitationText = invitationTextGenerator.GetInvitationText(person);

            Console.WriteLine(invitationText);
            //throw new Exception(invitationText);
        }
    }
}
