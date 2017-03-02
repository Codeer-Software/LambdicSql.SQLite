using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SQLite
{
    /// <summary>
    /// SQL Symbols.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// Use[using static LambdicSql.SQLite.Symbol;], you can use to write natural SQL.
    /// </summary>
    public static partial class Symbol
    {
        /// <summary>
        /// It's *.
        /// </summary>
        /// <typeparam name="TSelected">Type of selected.</typeparam>
        /// <param name="selected">The type you want to obtain with the SELECT clause. Usually you specify a table element.</param>
        /// <returns>*</returns>
        [ClauseStyleConverter(Name = "*")]
        public static AsteriskElement<TSelected> Asterisk<TSelected>(TSelected selected) { throw new InvalitContextException(nameof(Asterisk)); }

        /// <summary>
        /// It's *.
        /// </summary>
        /// <typeparam name="TSelected">Type of selected.</typeparam>
        /// <returns>*</returns>
        [ClauseStyleConverter(Name = "*")]
        public static AsteriskElement<TSelected> Asterisk<TSelected>() { throw new InvalitContextException(nameof(Asterisk)); }

        /// <summary>
        /// It's *.
        /// </summary>
        /// <returns>*</returns>
        [ClauseStyleConverter(Name = "*")]
        public static AsteriskElement Asterisk() { throw new InvalitContextException(nameof(Asterisk)); }

        /// <summary>
        /// ASC Keyword.
        /// </summary>
        /// <param name="target">target column.</param>
        /// <returns>ASC.</returns>
        [MethodFormatConverter(Format = "[0] ASC")]
        public static OrderByElement Asc(object target) { throw new InvalitContextException(nameof(Asc)); }

        /// <summary>
        /// DESC Keyword.
        /// </summary>
        /// <param name="target">target column.</param>
        /// <returns>DESC.</returns>
        [MethodFormatConverter(Format = "[0] DESC")]
        public static OrderByElement Desc(object target) { throw new InvalitContextException(nameof(Desc)); }

        /// <summary>
        /// ALL Keyword
        /// </summary>
        /// <returns>ALL.</returns>
        [ClauseStyleConverter]
        public static AggregatePredicateAllElement All() { throw new InvalitContextException(nameof(All)); }

        /// <summary>
        /// DISTINCT Keyword.
        /// </summary>
        /// <returns>DISTINCT.</returns>
        [ClauseStyleConverter]
        public static AggregatePredicateElement Distinct() { throw new InvalitContextException(nameof(All)); }
    }
}
