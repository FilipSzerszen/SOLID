using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Button submitButon = new Button();
            Checkbox clientType = new Checkbox();

            new RegisterClientView(clientType, submitButon);

            submitButon.Click();
            clientType.Select();
        }
    }
}
