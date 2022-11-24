namespace Vererbung2
{
    internal class Einwohner
    {
        private int einkommen;

        public Einwohner(int einkommen)
        {
            this.einkommen = einkommen;
        }

        public int GetEinkommen()
        {
            return this.einkommen;
        }

        public virtual int BerechneZuVersteuerndesEinkommen()
        {
            return (int) (this.GetEinkommen() * 0.1);
        }

        public virtual int BerechneSteuer()
        {
            if (this.BerechneZuVersteuerndesEinkommen() < 1)
            {
                return 1;
            }

            return (int)Math.Round(0.1 * this.BerechneZuVersteuerndesEinkommen());
        }

        public override string ToString()
        {
            return $"Einwohnertype: {GetType().Name},\nEinkommen: ${GetEinkommen()},\nSteuer: ${BerechneSteuer()}"; 
        }
    }
}
