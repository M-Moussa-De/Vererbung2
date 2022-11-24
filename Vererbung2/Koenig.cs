namespace Vererbung2
{
    internal class Koenig : Einwohner
    {
        public Koenig(int einkommen) : base(einkommen)
        {
        }

        public override int BerechneSteuer()
        {
            return 0;
        }
    }
}
