namespace Vererbung2
{
    internal class Adel : Einwohner
    {
        public Adel(int einkommen) : base(einkommen)
        {
        }

        public  int BerechneSteuer()
        {
            if (base.BerechneSteuer() < 20)
            {
                return 20;
            }

            return this.BerechneSteuer();
        }
    }
}
