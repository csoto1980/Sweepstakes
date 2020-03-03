namespace SweepstakesProject
{
    internal interface ISweepstakesManager
    {
        void InsertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();
    }
}