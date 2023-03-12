using System;

namespace Game2048.Utils
{
    internal static class MathUtils
    {
        /// <summary>
        /// 対数(log10)を取って数値の桁数を調べる
        /// </summary>
        public static int GetDigitCount(int value)
        {
            // NegativeInfinityを回避
            return (value == 0) ? 1 : ((int)Math.Log10(value) + 1);
        }
    }
}
