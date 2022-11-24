namespace Vererbung2
{
    internal class Leibeigener : Bauer
    {
        public Leibeigener(int einkommen) : base(einkommen)
        {
        }

        public override int BerechneZuVersteuerndesEinkommen()
        {
            return (int) (0.1 * (base.GetEinkommen() - 12));
        }

    }
}
