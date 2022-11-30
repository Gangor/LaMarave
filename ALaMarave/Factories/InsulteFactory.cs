using System;
using System.Collections.Generic;

namespace ALaMarave.Factories
{
    class InsulteFactory : IInsulteFactory
    {

        List<string> insultes = new List<string>();
        Random rdm = new Random();
        
        public string creerInsulte()
        {
            insultes.Add("Sac à crotte !");
            insultes.Add("SELECT Tarte FROM maMain WHERE DansTaGueule ;");
            insultes.Add("T'es tellement geek que la seule chose que tu peux lever, c'est une exception !");
            insultes.Add("T'as été fini au VB toi !");
            insultes.Add("Trou de balle");

            return insultes[rdm.Next(0,insultes.Count+1)];

        }
    }
}
