public class Calc
{
    const double MAXIMO=22;
    const double MINIMO=-22;

    static public double Rv=0;
    static public double Lv=0;

    static public double CalcRightActuator(double R, double P,double X, double Y,double Z)
    {
        Rv += ((R + P + X + Y + Z ) - Rv);
        Rv = Math.Min(Rv, MAXIMO);
        Rv = Math.Max(Rv, MINIMO);
//      Inverted
        return (Rv * -1);
    }

    static public double CalcLeftActuator(double R, double P,double X, double Y,double Z)
    {
        Lv += ((-R + P - X + Y + Z ) - Lv);
        Lv = Math.Min(Lv, MAXIMO);
        Lv = Math.Max(Lv, MINIMO);

        return (Lv);
    }
}
