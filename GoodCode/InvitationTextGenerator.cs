namespace GoodCode
{
    public class InvitationTextGenerator
    {
        public string GetInvitationText(Person person)
        {
            return $"Здравствуйте, {person.FullName}! Приглашаем Вас на нашу свадьбу.";
            //return $"Здравствуй, {person.FullName}! Приглашаем Вас на нашу свадьбу.";
        }
    }
}
