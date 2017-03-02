using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.SQLite
{
    /// <summary>
    /// Data type.
    /// It can only be used within lambda of the LambdicSql.
    /// </summary>
    public static class DataType
    {
        /// <summary>
        /// BIGINT
        /// </summary>
        /// <returns>BIGINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement BigInt() { throw new InvalitContextException(nameof(BigInt)); }

        /// <summary>
        /// BLOB
        /// </summary>
        /// <returns>BLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Blob() { throw new InvalitContextException(nameof(Blob)); }

        /// <summary>
        /// BOOLEAN
        /// </summary>
        /// <returns>BOOLEAN</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Boolean() { throw new InvalitContextException(nameof(Boolean)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <returns>CHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Char() { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement Char(int n) { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHARACTER
        /// </summary>
        /// <returns>CHARACTER</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Character() { throw new InvalitContextException(nameof(Character)); }

        /// <summary>
        /// CHARACTER
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHARACTER</returns>
        [FuncStyleConverter]
        public static DataTypeElement Character(int n) { throw new InvalitContextException(nameof(Character)); }

        /// <summary>
        /// CLOB
        /// </summary>
        /// <returns>CLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Clob() { throw new InvalitContextException(nameof(Clob)); }

        /// <summary>
        /// DATE
        /// </summary>
        /// <returns>DATE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Date() { throw new InvalitContextException(nameof(Date)); }

        /// <summary>
        /// DATETIME
        /// </summary>
        /// <returns>DATETIME</returns>
        [ClauseStyleConverter]
        public static DataTypeElement DateTime() { throw new InvalitContextException(nameof(DateTime)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal() { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision) { throw new InvalitContextException(nameof(Decimal)); }


        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision, int scale) { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DOUBLE
        /// </summary>
        /// <returns>DOUBLE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Double() { throw new InvalitContextException(nameof(Double)); }

        /// <summary>
        /// DOUBLE PRECISION
        /// </summary>
        /// <returns>DOUBLE PRECISION</returns>
        [ClauseStyleConverter(Name = "DOUBLE PRECISION")]
        public static DataTypeElement DoublePrecision() { throw new InvalitContextException(nameof(DoublePrecision)); }

        /// <summary>
        /// FLOAT
        /// </summary>
        /// <returns>FLOAT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Float() { throw new InvalitContextException(nameof(Float)); }

        /// <summary>
        /// FLOAT
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>FLOAT</returns>
        [FuncStyleConverter]
        public static DataTypeElement Float(int n) { throw new InvalitContextException(nameof(Float)); }

        /// <summary>
        /// INT
        /// </summary>
        /// <returns>INT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int() { throw new InvalitContextException(nameof(Int)); }

        /// <summary>
        /// INT2
        /// </summary>
        /// <returns>INT2</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int2() { throw new InvalitContextException(nameof(Int2)); }

        /// <summary>
        /// INT8
        /// </summary>
        /// <returns>INT8</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int8() { throw new InvalitContextException(nameof(Int8)); }

        /// <summary>
        /// INTEGER
        /// </summary>
        /// <returns>INTEGER</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Integer() { throw new InvalitContextException(nameof(Integer)); }

        /// <summary>
        /// MEDIUMINT
        /// </summary>
        /// <returns>MEDIUMINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement MediumInt() { throw new InvalitContextException(nameof(MediumInt)); }

        /// <summary>
        /// NATIVE CHARACTER
        /// </summary>
        /// <returns>NATIVE CHARACTER</returns>
        [ClauseStyleConverter(Name = "NATIVE CHARACTER")]
        public static DataTypeElement NativeCharacter() { throw new InvalitContextException(nameof(NativeCharacter)); }

        /// <summary>
        /// NATIVE CHARACTER
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NATIVE CHARACTER</returns>
        [FuncStyleConverter(Name = "NATIVE CHARACTER")]
        public static DataTypeElement NativeCharacter(int n) { throw new InvalitContextException(nameof(NativeCharacter)); }

        /// <summary>
        /// NCHAR
        /// </summary>
        /// <returns>NCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NChar() { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// NCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement NChar(int n) { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <returns>NUMERIC</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Numeric() { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NUMERIC
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>NUMERIC</returns>
        [FuncStyleConverter]
        public static DataTypeElement Numeric(int precision, int scale) { throw new InvalitContextException(nameof(Numeric)); }

        /// <summary>
        /// NVARCHAR
        /// </summary>
        /// <returns>NVARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NVarChar() { throw new InvalitContextException(nameof(NVarChar)); }

        /// <summary>
        /// NVARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NVARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement NVarChar(int n) { throw new InvalitContextException(nameof(NVarChar)); }

        /// <summary>
        /// REAL
        /// </summary>
        /// <returns>REAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Real() { throw new InvalitContextException(nameof(Real)); }

        /// <summary>
        /// SET
        /// </summary>
        /// <returns>SET</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Set() { throw new InvalitContextException(nameof(Set)); }

        /// <summary>
        /// SMALLINT
        /// </summary>
        /// <returns>SMALLINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement SmallInt() { throw new InvalitContextException(nameof(SmallInt)); }

        /// <summary>
        /// TEXT
        /// </summary>
        /// <returns>TEXT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Text() { throw new InvalitContextException(nameof(Text)); }

        /// <summary>
        /// TINYINT
        /// </summary>
        /// <returns>TINYINT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TinyInt() { throw new InvalitContextException(nameof(TinyInt)); }

        /// <summary>
        /// UNSIGNED BIG INT
        /// </summary>
        /// <returns>UNSIGNED BIG INT</returns>
        [ClauseStyleConverter(Name = "UNSIGNED BIG INT")]
        public static DataTypeElement UnsignedBigInt() { throw new InvalitContextException(nameof(UnsignedBigInt)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <returns>VARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar() { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar(int n) { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARYING CHARACTER
        /// </summary>
        /// <returns>VARYING CHARACTER</returns>
        [ClauseStyleConverter(Name = "VARYING CHARACTER")]
        public static DataTypeElement VaryingCharacter() { throw new InvalitContextException(nameof(VaryingCharacter)); }

        /// <summary>
        /// VARYING CHARACTER
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARYING CHARACTER</returns>
        [FuncStyleConverter(Name = "VARYING CHARACTER")]
        public static DataTypeElement VaryingCharacter(int n) { throw new InvalitContextException(nameof(VaryingCharacter)); }
    }
}
