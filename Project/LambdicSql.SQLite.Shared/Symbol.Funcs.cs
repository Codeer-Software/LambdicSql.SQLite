using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SQLite
{
    /// <summary>
    /// SQL Symbols.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.Keywords;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// SUM function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Total.</returns>
        [FuncStyleConverter]
        public static T Sum<T>(T column) { throw new InvalitContextException(nameof(Sum)); }

        /// <summary>
        /// SUM function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Total.</returns>
        [MethodFormatConverter(Format = "SUM(|[0] [1])")]
        public static T Sum<T>(AggregatePredicateElement aggregatePredicate, T column) { throw new InvalitContextException(nameof(Sum)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count(object column) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [FuncStyleConverter]
        public static int Count(AsteriskElement asterisk) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT(|[0] [1])")]
        public static int Count(AggregatePredicateElement aggregatePredicate, object column) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// COUNT function.
        /// </summary>
        /// <param name="aggregatePredicate">Specify All or Distinct.</param>
        /// <param name="asterisk">*</param>
        /// <returns>Count.</returns>
        [MethodFormatConverter(Format = "COUNT(|[0] [1])")]
        public static int Count(AggregatePredicateElement aggregatePredicate, AsteriskElement asterisk) { throw new InvalitContextException(nameof(Count)); }

        /// <summary>
        /// AVG function.
        /// </summary>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Average.</returns>
        [FuncStyleConverter]
        public static double Avg(object column) { throw new InvalitContextException(nameof(Avg)); }

        /// <summary>
        /// MIN function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Minimum.</returns>
        [FuncStyleConverter]
        public static T Min<T>(T column) { throw new InvalitContextException(nameof(Min)); }

        /// <summary>
        /// MAX function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Maximum.</returns>
        [FuncStyleConverter]
        public static T Max<T>(T column) { throw new InvalitContextException(nameof(Max)); }

        /// <summary>
        /// ABS function.
        /// </summary>
        /// <typeparam name="T">Type represented by expression.</typeparam>
        /// <param name="column">The column or expression that is function target.</param>
        /// <returns>Absolute value.</returns>
        [FuncStyleConverter]
        public static T Abs<T>(T column) { throw new InvalitContextException(nameof(Abs)); }

        /// <summary>
        /// ROUND function.
        /// </summary>
        /// <typeparam name="T1">Type represented by target.</typeparam>
        /// <typeparam name="T2">Type represented by digit</typeparam>
        /// <param name="target">Numeric expression to round.</param>
        /// <param name="digit">Is the precision to which it is to be rounded.</param>
        /// <returns>Rounded result.</returns>
        [FuncStyleConverter]
        public static T1 Round<T1, T2>(T1 target, T2 digit) { throw new InvalitContextException(nameof(Round)); }

        /// <summary>
        /// LOWER function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Lower(object target) { throw new InvalitContextException(nameof(Lower)); }

        /// <summary>
        /// UPPER function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Upper(object target) { throw new InvalitContextException(nameof(Upper)); }

        /// <summary>
        /// REPLACE function.
        /// </summary>
        /// <param name="target">target.</param>
        /// <param name="src">source.</param>
        /// <param name="dst">destination.</param>
        /// <returns>Changed string.</returns>
        [FuncStyleConverter]
        public static string Replace(object target, object src, object dst) { throw new InvalitContextException(nameof(Replace)); }

        /// <summary>
        /// COALESCE function.
        /// </summary>
        /// <typeparam name="T">Type of parameter</typeparam>
        /// <param name="parameter">Parameter.</param>
        /// <returns>The first non-null value in the parameter.</returns>
        [MethodFormatConverter(Format = "COALESCE(|[<, >0])")]
        public static T Coalesce<T>(params T[] parameter) { throw new InvalitContextException(nameof(Coalesce)); }
    }
}
