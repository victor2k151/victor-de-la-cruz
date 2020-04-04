using System;
class Program
{
    static void Main(string[] args)
    {
        string pin;
        int n, tipcue; //tipcue=tipo de cuenta
        double credito = 100000;
        do
        {
            Console.WriteLine("digite su pin");
            pin = Console.ReadLine();
            if (pin == "1504")
            {
                double cuentac = 100000, cuentaaho = 100000, saldo = cuentac + cuentaaho;
                Console.WriteLine("Bienvenida sra. Johanna Felipe");
                Console.WriteLine("Digite la operacion a realizar");
                Console.WriteLine("1 retiro, 2 consulta");
                int res = int.Parse(Console.ReadLine());
                n = res;
                if (n == 2)
                {
                    Console.WriteLine("su saldo total es {0} ", saldo);
                    Console.WriteLine("su saldo de cuenta corriente es: {0} ", cuentac);
                    Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cuentaaho);
                    Console.WriteLine("su saldo de tarjeta de credito es: {0} ", credito);
                }
                if (n == 1)
                {
                    Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros 3 cuenta de credito");
                    tipcue = int.Parse(Console.ReadLine());
                    if (tipcue == 1)
                    {
                        while (res == 1)
                        {
                            Console.WriteLine("Digite el monto a retirar");
                            double ret = double.Parse(Console.ReadLine());
                            if (ret <= saldo)
                            {
                                saldo = saldo - ret;
                                cuentac = cuentac - ret;
                                Console.WriteLine("su saldo es: {0} ", saldo);
                            }
                            else
                            {
                                Console.WriteLine("su saldo total disponible es inferior a {0}", ret);
                                Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saldo);
                            }
                            Console.WriteLine("Desea realizar otro retiro");
                            Console.WriteLine("1 = si 2 = no ");
                            res = int.Parse(Console.ReadLine());
                        }
                    }
                    if (tipcue == 2)
                    {
                        while (res == 1)
                        {
                            Console.WriteLine("Digite el monto a retirar");
                            double ret = double.Parse(Console.ReadLine());
                            if (ret <= saldo)
                            {
                                saldo = saldo - ret;
                                cuentaaho = cuentaaho - ret;
                                Console.WriteLine("su saldo de cuenta corriente es: {0} ", cuentac);
                                Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cuentaaho);
                                Console.WriteLine("su saldo de tarjeta de credito es: {0} ", credito);
                            }
                            else
                            {
                                Console.WriteLine("su saldo total disponible es {0}", saldo);
                                Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                            }
                            Console.WriteLine("Desea realizar otro retiro");
                            Console.WriteLine("1 = si 2 = no ");
                            res = int.Parse(Console.ReadLine());
                        }
                    }
                    if (tipcue == 3)
                    {
                        Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                    }
                }
            }
            else
            {
                if (pin == "9721")
                {
                    double cuentac = 100000, cuentaaho = 100000, saldo = cuentac + cuentaaho;
                    Console.WriteLine("Bienvenido sr. Victor de la Cruz ");
                    Console.WriteLine("Digite la operacion a realizar");
                    Console.WriteLine("1 retiro, 2 consulta");
                    int res = int.Parse(Console.ReadLine());
                    n = res;
                    if (n == 2)
                    {
                        Console.WriteLine("su saldo total disponible es {0} ", saldo);
                        Console.WriteLine("su saldo de cuenta corriente es: {0} ", cuentac);
                        Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cuentaaho);
                        Console.WriteLine("su saldo de tarjeta de credito es: {0} ", credito);
                    }
                    if (n == 1)
                    {
                        Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                        tipcue = int.Parse(Console.ReadLine());
                        if (tipcue == 1)
                        {
                            while (res == 1)
                            {
                                Console.WriteLine("Digite el monto a retirar");
                                double ret = double.Parse(Console.ReadLine());
                                if (ret <= saldo)
                                {
                                    saldo = saldo - ret;
                                    cuentac = cuentac - ret;
                                    Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                }
                                else
                                {
                                    Console.WriteLine("su saldo total disponible es inferior a {0}", ret);
                                    Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saldo);
                                }
                                Console.WriteLine("Desea realizar otro retiro");
                                Console.WriteLine("1 = si 2 = no ");
                                res = int.Parse(Console.ReadLine());
                            }
                        }
                        if (tipcue == 2)
                        {
                            while (res == 1)
                            {
                                Console.WriteLine("Digite el monto a retirar");
                                double ret = double.Parse(Console.ReadLine());
                                if (ret <= saldo)
                                {
                                    saldo = saldo - ret;
                                    cuentaaho = cuentaaho - ret;
                                    Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                }
                                else
                                {
                                    Console.WriteLine("su saldo disponible es {0}", saldo);
                                    Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                }
                                Console.WriteLine("Desea realizar otro retiro");
                                Console.WriteLine("1 = si 2 = no ");
                                res = int.Parse(Console.ReadLine());
                            }
                        }
                        if (tipcue == 3)
                        {
                            Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                        }
                    }
                }
                else
                {
                    if (pin == "12345")
                    {
                        double cuentac = 100000, cuentaaho = 100000, saldo = cuentac + cuentaaho;
                        Console.WriteLine("Bienvenido sr. Bernardo Bonifacio");
                        Console.WriteLine("Digite la operacion a realizar");
                        Console.WriteLine("1 retiro, 2 consulta");
                        int res = int.Parse(Console.ReadLine());
                        n = res;
                        if (n == 2)
                        {
                            Console.WriteLine("su saldo total disponibe es: {0} ", saldo);
                            Console.WriteLine("su saldo de cuenta corriente es: {0} ", cuentac);
                            Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cuentaaho);
                            Console.WriteLine("su saldo de tarjeta de credito es: {0} ", credito);
                        }
                        if (n == 1)
                        {
                            Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                            tipcue = int.Parse(Console.ReadLine());
                            if (tipcue == 1)
                            {
                                while (res == 1)
                                {
                                    Console.WriteLine("Digite el monto a retirar");
                                    double ret = double.Parse(Console.ReadLine());
                                    if (ret <= saldo)
                                    {
                                        saldo = saldo - ret;
                                        cuentac = cuentac - ret;
                                        Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("su saldo disponible es inferior a {0}", ret);
                                        Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saldo);
                                    }
                                    Console.WriteLine("Desea realizar otro retiro");
                                    Console.WriteLine("1 = si 2 = no ");
                                    res = int.Parse(Console.ReadLine());
                                }
                            }
                            if (tipcue == 2)
                            {
                                while (res == 1)
                                {
                                    Console.WriteLine("Digite el monto a retirar");
                                    double ret = double.Parse(Console.ReadLine());
                                    if (ret <= saldo)
                                    {
                                        saldo = saldo - ret;
                                        cuentaaho = cuentaaho - ret;
                                        Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("su saldo total disponible es {0}", saldo);
                                        Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                    }
                                    Console.WriteLine("Desea realizar otro retiro");
                                    Console.WriteLine("1 = si 2 = no ");
                                    res = int.Parse(Console.ReadLine());
                                }
                            }
                            if (tipcue == 3)
                            {
                                Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                            }
                        }
                    }
                    else
                    {
                        if (pin == "123456")
                        {
                            double cuentac = 100000, cuentaaho = 100000, saldo = cuentac + cuentaaho;
                            Console.WriteLine("Bienvenido sr. Carlos Felipe");
                            Console.WriteLine("Digite la operacion a realizar");
                            Console.WriteLine("1 retiro, 2 consulta");
                            int res = int.Parse(Console.ReadLine());
                            n = res;
                            if (n == 2)
                            {
                                Console.WriteLine("su saldo disponible es: {0} ", saldo);
                                Console.WriteLine("su saldo de cuenta corriente es: {0} ", cuentac);
                                Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cuentaaho);
                                Console.WriteLine("su saldo de tarjeta de credito es: {0} ", credito);
                            }
                            if (n == 1)
                            {
                                Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                                tipcue = int.Parse(Console.ReadLine());
                                if (tipcue == 1)
                                {
                                    while (res == 1)
                                    {
                                        Console.WriteLine("Digite el monto a retirar");
                                        double ret = double.Parse(Console.ReadLine());
                                        if (ret <= saldo)
                                        {
                                            saldo = saldo - ret;
                                            cuentac = cuentac - ret;
                                            Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                        }
                                        else
                                        {
                                            Console.WriteLine("su saldo es disponible es inferior a {0}", ret);
                                            Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saldo);
                                        }
                                        Console.WriteLine("Desea realizar otro retiro");
                                        Console.WriteLine("1 = si 2 = no ");
                                        res = int.Parse(Console.ReadLine());
                                    }
                                }
                                if (tipcue == 2)
                                {
                                    while (res == 1)
                                    {
                                        Console.WriteLine("Digite el monto a retirar");
                                        double ret = double.Parse(Console.ReadLine());
                                        if (ret <= saldo)
                                        {
                                            saldo = saldo - ret;
                                            cuentaaho = cuentaaho - ret;
                                            Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                        }
                                        else
                                        {
                                            Console.WriteLine("su saldo disponible es {0}", saldo);
                                            Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                        }
                                        Console.WriteLine("Desea realizar otro retiro");
                                        Console.WriteLine("1 = si 2 = no ");
                                        res = int.Parse(Console.ReadLine());
                                    }
                                }
                                if (tipcue == 3)
                                {
                                    Console.WriteLine("lo sentimos esta cuenta es solo para pagos no para retiros");
                                }
                            }
                        }
                        else
                        {
                            if (pin == "1234567")
                            {
                                double cuentac = 100000, cuentaaho = 100000, saldo = cuentac + cuentaaho;
                                Console.WriteLine("Bienvenido sr. Evangelista de la Cruz");
                                Console.WriteLine("Digite la operacion a realizar");
                                Console.WriteLine("1 retiro, 2 consulta");
                                int res = int.Parse(Console.ReadLine());
                                n = res;
                                if (n == 2)
                                {
                                    Console.WriteLine("su saldo disponible es: {0} ", saldo);
                                    Console.WriteLine("su saldo de cuenta corriente es: {0} ", cuentac);
                                    Console.WriteLine("su saldo de cuenta de ahorro es: {0} ", cuentaaho);
                                    Console.WriteLine("su saldo de tarjeta de credito es: {0} ", credito);
                                }
                                if (n == 1)
                                {
                                    Console.WriteLine("1 cuenta corriente 2 cuenta de ahorros");
                                    tipcue = int.Parse(Console.ReadLine());
                                    if (tipcue == 1)
                                    {
                                        while (res == 1)
                                        {
                                            Console.WriteLine("Digite el monto a retirar");
                                            double ret = double.Parse(Console.ReadLine());
                                            if (ret <= saldo)
                                            {
                                                saldo = saldo - ret;
                                                cuentac = cuentac - ret;
                                                Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                            }
                                            else
                                            {
                                                Console.WriteLine("su saldo dosponible es inferior a {0}", ret);
                                                Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", saldo);
                                            }
                                            Console.WriteLine("Desea realizar otro retiro");
                                            Console.WriteLine("1 = si 2 = no ");
                                            res = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    if (tipcue == 2)
                                    {
                                        while (res == 1)
                                        {
                                            Console.WriteLine("Digite el monto a retirar");
                                            double ret = double.Parse(Console.ReadLine());
                                            if (ret <= saldo)
                                            {
                                                saldo = saldo - ret;
                                                cuentaaho = cuentaaho - ret;
                                                Console.WriteLine("su saldo total disponible es: {0} ", saldo);
                                            }
                                            else
                                            {
                                                Console.WriteLine("su saldo disponible es {0}", saldo);
                                                Console.WriteLine("porfavor ingrese una cantidad inferior a {0}", ret);
                                            }
                                            Console.WriteLine("Desea realizar otro retiro");
                                            Console.WriteLine("1 = si 2 = no ");
                                            res = int.Parse(Console.ReadLine());
                                        }
                                    }
                                    if (tipcue == 3)
                                    {
                                        Console.WriteLine("Lo sentimos esta cuenta es solo para pagos no para retiros");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Lo sentimos pin erroneo ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Desea realizar otra transaccion s/n");
            pin = Console.ReadLine();
        }
        while (pin == "s");
        Console.WriteLine("Gracias por preferirnos, que pase un buen resto del dia.");
        Console.ReadLine();
        Console.WriteLine("Retire su tarjeta");
        Console.ReadLine();
    }
}