using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public class Selection
    {
        public void Controle(int value)
        {
            if (value != 10)
                throw new ArgumentException($"de formatie moet exact 10 spelers hebben");

        }
    }
}
