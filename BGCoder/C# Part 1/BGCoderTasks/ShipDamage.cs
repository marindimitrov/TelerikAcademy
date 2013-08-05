using System;

class ShipDamage
{
    static void Main()
    {
        int sX1 = int.Parse(Console.ReadLine());
        int sY1 = int.Parse(Console.ReadLine());

        int sX2 = int.Parse(Console.ReadLine());
        int sY2 = int.Parse(Console.ReadLine());

        int h = int.Parse(Console.ReadLine());

        int cX1 = int.Parse(Console.ReadLine());
        int cY1 = int.Parse(Console.ReadLine());

        int cX2 = int.Parse(Console.ReadLine());
        int cY2 = int.Parse(Console.ReadLine());

        int cX3 = int.Parse(Console.ReadLine());
        int cY3 = int.Parse(Console.ReadLine());

        int damageC1 = 0;
        int damageC2 = 0;
        int damageC3 = 0;

        int damage = 0;

        //============================================================================Down and Right rectangle
        if (sX1 < sX2 && sY1 > sY2)
        {
            //------------------------------------------- Damage from C1
            if (cX1 < sX1 || cX1 > sX2)
            {
                damageC1 = 0;
            }
            else if (cX1 == sX1 || cX1 == sX2)
            {
                if (h - cY1 > sY1 - h || h - cY1 < sY2 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY1 - h || h - cY1 == sY2 - h)
                {
                    damageC1 = 25;
                }
                else if (h - cY1 < sY1 - h && h - cY1 > sY2 - h)
                {
                    damageC1 = 50;
                }
            }
            else if (cX1 > sX1 && cX1 < sX2)
            {
                if (h - cY1 > sY1 - h || h - cY1 < sY2 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY1 - h || h - cY1 == sY2 - h)
                {
                    damageC1 = 50;
                }
                else if (h - cY1 < sY1 - h && h - cY1 > sY2 - h)
                {
                    damageC1 = 100;
                }
            }
            //------------------------------------------- Damage from C2
            if (cX2 < sX1 || cX2 > sX2)
            {
                damageC2 = 0;
            }
            else if (cX2 == sX1 || cX2 == sX2)
            {
                if (h - cY2 > sY1 - h || h - cY2 < sY2 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY1 - h || h - cY2 == sY2 - h)
                {
                    damageC2 = 25;
                }
                else if (h - cY2 < sY1 - h && h - cY2 > sY2 - h)
                {
                    damageC2 = 50;
                }
            }
            else if (cX2 > sX1 && cX2 < sX2)
            {
                if (h - cY2 > sY1 - h || h - cY2 < sY2 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY1 - h || h - cY2 == sY2 - h)
                {
                    damageC2 = 50;
                }
                else if (h - cY2 < sY1 - h && h - cY2 > sY2 - h)
                {
                    damageC2 = 100;
                }
            }
            //------------------------------------------- Damage from C3
            if (cX3 < sX1 || cX3 > sX2)
            {
                damageC3 = 0;
            }
            else if (cX3 == sX1 || cX3 == sX2)
            {
                if (h - cY3 > sY1 - h || h - cY3 < sY2 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY1 - h || h - cY3 == sY2 - h)
                {
                    damageC3 = 25;
                }
                else if (h - cY3 < sY1 - h && h - cY3 > sY2 - h)
                {
                    damageC3 = 50;
                }
            }
            else if (cX3 > sX1 && cX3 < sX2)
            {
                if (h - cY3 > sY1 - h || h - cY3 < sY2 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY1 - h || h - cY3 == sY2 - h)
                {
                    damageC3 = 50;
                }
                else if (h - cY3 < sY1 - h && h - cY3 > sY2 - h)
                {
                    damageC3 = 100;
                }
            }
            //------------------------------------------- Total damage = C1 + C2 + C3
            damage = damageC1 + damageC2 + damageC3;
            Console.WriteLine("{0}%", damage);
        }

        //============================================================================Down and Left rectangle
        if (sX1 > sX2 && sY1 > sY2)
        {
            //------------------------------------------- Damage from C1
            if (cX1 < sX2 || cX1 > sX1)
            {
                damageC1 = 0;
            }
            else if (cX1 == sX1 || cX1 == sX2)
            {
                if (h - cY1 > sY1 - h || h - cY1 < sY2 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY1 - h || h - cY1 == sY2 - h)
                {
                    damageC1 = 25;
                }
                else if (h - cY1 < sY1 - h && h - cY1 > sY2 - h)
                {
                    damageC1 = 50;
                }
            }
            else if (cX1 < sX1 && cX1 > sX2)
            {
                if (h - cY1 > sY1 - h || h - cY1 < sY2 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY1 - h || h - cY1 == sY2 - h)
                {
                    damageC1 = 50;
                }
                else if (h - cY1 < sY1 - h && h - cY1 > sY2 - h)
                {
                    damageC1 = 100;
                }
            }
            //------------------------------------------- Damage from C2
            if (cX2 < sX2 || cX2 > sX1)
            {
                damageC2 = 0;
            }
            else if (cX2 == sX1 || cX2 == sX2)
            {
                if (h - cY2 > sY1 - h || h - cY2 < sY2 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY1 - h || h - cY2 == sY2 - h)
                {
                    damageC2 = 25;
                }
                else if (h - cY2 < sY1 - h && h - cY2 > sY2 - h)
                {
                    damageC2 = 50;
                }
            }
            else if (cX2 < sX1 && cX2 > sX2)
            {
                if (h - cY2 > sY1 - h || h - cY2 < sY2 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY1 - h || h - cY2 == sY2 - h)
                {
                    damageC2 = 50;
                }
                else if (h - cY2 < sY1 - h && h - cY2 > sY2 - h)
                {
                    damageC2 = 100;
                }
            }
            //------------------------------------------- Damage from C3
            if (cX3 < sX2 || cX3 > sX1)
            {
                damageC3 = 0;
            }
            else if (cX3 == sX1 || cX3 == sX2)
            {
                if (h - cY3 > sY1 - h || h - cY3 < sY2 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY1 - h || h - cY3 == sY2 - h)
                {
                    damageC3 = 25;
                }
                else if (h - cY3 < sY1 - h && h - cY3 > sY2 - h)
                {
                    damageC3 = 50;
                }
            }
            else if (cX3 < sX1 && cX3 > sX2)
            {
                if (h - cY3 > sY1 - h || h - cY3 < sY2 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY1 - h || h - cY3 == sY2 - h)
                {
                    damageC3 = 50;
                }
                else if (h - cY3 < sY1 - h && h - cY3 > sY2 - h)
                {
                    damageC3 = 100;
                }
            }
            //------------------------------------------- Total damage = C1 + C2 + C3
            damage = damageC1 + damageC2 + damageC3;
            Console.WriteLine("{0}%", damage);
        }

        //============================================================================Up and Left rectangle
        if (sX1 > sX2 && sY1 < sY2)
        {
            //------------------------------------------- Damage from C1
            if (cX1 < sX2 || cX1 > sX1)
            {
                damageC1 = 0;
            }
            else if (cX1 == sX1 || cX1 == sX2)
            {
                if (h - cY1 > sY2 - h || h - cY1 < sY1 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY2 - h || h - cY1 == sY1 - h)
                {
                    damageC1 = 25;
                }
                else if (h - cY1 < sY2 - h && h - cY1 > sY1 - h)
                {
                    damageC1 = 50;
                }
            }
            else if (cX1 < sX1 && cX1 > sX2)
            {
                if (h - cY1 > sY2 - h || h - cY1 < sY1 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY2 - h || h - cY1 == sY1 - h)
                {
                    damageC1 = 50;
                }
                else if (h - cY1 < sY2 - h && h - cY1 > sY1 - h)
                {
                    damageC1 = 100;
                }
            }
            //------------------------------------------- Damage from C2
            if (cX2 < sX2 || cX2 > sX1)
            {
                damageC2 = 0;
            }
            else if (cX2 == sX1 || cX2 == sX2)
            {
                if (h - cY2 > sY2 - h || h - cY2 < sY1 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY2 - h || h - cY2 == sY1 - h)
                {
                    damageC2 = 25;
                }
                else if (h - cY2 < sY2 - h && h - cY2 > sY1 - h)
                {
                    damageC2 = 50;
                }
            }
            else if (cX2 < sX1 && cX2 > sX2)
            {
                if (h - cY2 > sY2 - h || h - cY2 < sY1 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY2 - h || h - cY2 == sY1 - h)
                {
                    damageC2 = 50;
                }
                else if (h - cY2 < sY2 - h && h - cY2 > sY1 - h)
                {
                    damageC2 = 100;
                }
            }
            //------------------------------------------- Damage from C3
            if (cX1 < sX2 || cX1 > sX1)
            {
                damageC3 = 0;
            }
            else if (cX3 == sX1 || cX3 == sX2)
            {
                if (h - cY3 > sY2 - h || h - cY3 < sY1 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY3 == sY2 - h || h - cY3 == sY1 - h)
                {
                    damageC3 = 25;
                }
                else if (h - cY3 < sY2 - h && h - cY3 > sY1 - h)
                {
                    damageC3 = 50;
                }
            }
            else if (cX3 < sX1 && cX3 > sX2)
            {
                if (h - cY3 > sY2 - h || h - cY3 < sY1 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY2 - h || h - cY3 == sY1 - h)
                {
                    damageC3 = 50;
                }
                else if (h - cY3 < sY2 - h && h - cY3 > sY1 - h)
                {
                    damageC3 = 100;
                }
            }
            //------------------------------------------- Total damage = C1 + C2 + C3
            damage = damageC1 + damageC2 + damageC3;
            Console.WriteLine("{0}%", damage);
        }

        //============================================================================Up and Right rectangle
        if (sX1 < sX2 && sY1 < sY2)
        {
            //------------------------------------------- Damage from C1
            if (cX1 > sX2 || cX1 < sX1)
            {
                damageC1 = 0;
            }
            else if (cX1 == sX1 || cX1 == sX2)
            {
                if (h - cY1 > sY2 - h || h - cY1 < sY1 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY2 - h || h - cY1 == sY1 - h)
                {
                    damageC1 = 25;
                }
                else if (h - cY1 < sY2 - h && h - cY1 > sY1 - h)
                {
                    damageC1 = 50;
                }
            }
            else if (cX1 > sX1 && cX1 < sX2)
            {
                if (h - cY1 > sY2 - h || h - cY1 < sY1 - h)
                {
                    damageC1 = 0;
                }
                else if (h - cY1 == sY2 - h || h - cY1 == sY1 - h)
                {
                    damageC1 = 50;
                }
                else if (h - cY1 < sY2 - h && h - cY1 > sY1 - h)
                {
                    damageC1 = 100;
                }
            }
            //------------------------------------------- Damage from C2
            if (cX2 > sX2 || cX2 < sX1)
            {
                damageC2 = 0;
            }
            else if (cX2 == sX1 || cX2 == sX2)
            {
                if (h - cY2 > sY2 - h || h - cY2 < sY1 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY2 - h || h - cY2 == sY1 - h)
                {
                    damageC2 = 25;
                }
                else if (h - cY2 < sY2 - h && h - cY2 > sY1 - h)
                {
                    damageC2 = 50;
                }
            }
            else if (cX2 > sX1 && cX2 < sX2)
            {
                if (h - cY2 > sY2 - h || h - cY2 < sY1 - h)
                {
                    damageC2 = 0;
                }
                else if (h - cY2 == sY2 - h || h - cY2 == sY1 - h)
                {
                    damageC2 = 50;
                }
                else if (h - cY2 < sY2 - h && h - cY2 > sY1 - h)
                {
                    damageC2 = 100;
                }
            }
            //------------------------------------------- Damage from C3
            if (cX3 > sX2 || cX3 < sX1)
            {
                damageC3 = 0;
            }
            else if (cX3 == sX1 || cX3 == sX2)
            {
                if (h - cY3 > sY2 - h || h - cY3 < sY1 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY2 - h || h - cY3 == sY1 - h)
                {
                    damageC3 = 25;
                }
                else if (h - cY3 < sY2 - h && h - cY3 > sY1 - h)
                {
                    damageC3 = 50;
                }
            }
            else if (cX3 > sX1 && cX3 < sX2)
            {
                if (h - cY3 > sY2 - h || h - cY3 < sY1 - h)
                {
                    damageC3 = 0;
                }
                else if (h - cY3 == sY2 - h || h - cY3 == sY1 - h)
                {
                    damageC3 = 50;
                }
                else if (h - cY3 < sY2 - h && h - cY3 > sY1 - h)
                {
                    damageC3 = 100;
                }
            }
            //------------------------------------------- Total damage = C1 + C2 + C3
            damage = damageC1 + damageC2 + damageC3;
            Console.WriteLine("{0}%", damage);
        }
    }
}