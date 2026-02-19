using RimWorld;
using Verse;

namespace losefaith
{

    [StaticConstructorOnStartup]
    public static class LoseTheFaith
    {
        static LoseTheFaith()
        {
            ConversionTuning.CertaintyPerDayByMoodCurve.SetPoints(new SimpleCurve
            {
                new CurvePoint(0.0f, -0.02f),
                new CurvePoint(0.2f, -0.01f),
                new CurvePoint(0.4f, 0.00f),
                new CurvePoint(0.6f, 0.01f),
                new CurvePoint(0.8f, 0.02f),
                new CurvePoint(0.9f, 0.03f)
            });

        }

    }

 }

 





