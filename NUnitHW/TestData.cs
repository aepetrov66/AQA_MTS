namespace NUnitHW;

public class TestData
{
    public static object[] DivideCasesInt =
    {
        new object[] { 24, 3, 8 },
        new object[] { -24, 2, -12 },
        new object[] { 24, -4, -6 },
        new object[] { -24, -4, 6 },
        new object[] { 0, 4, 0 },
        new object[] { 5, 2, 2 }
    };

    public static object[] DivideCasesDouble =
{
        new object[] { 24, 3, 8 },
        new object[] { -24, 2, -12 },
        new object[] { 24, -4, -6 },
        new object[] { -24, -4, 6 },
        new object[] { 0, 4, 0 },
        new object[] { 5, 2, 2.5 },
        new object[] { 5.5, 2, 2.75 },
        new object[] { 6, 0.5, 12 }
    };
}
