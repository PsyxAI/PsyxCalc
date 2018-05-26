namespace PsyxCalc
{
    interface IOptics
    {
        float RefractiveIndex();
        bool IsTransparent();
        Properties.Range1D VisibleTo();
    }
}
