using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SQLite.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;
using LambdicSql.SQLite;

namespace Test
{
    [TestClass]
    public class TestDataType
    {
        public TestContext TestContext { get; set; }
        public IDbConnection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = TestEnvironment.CreateConnection(TestContext);
            _connection.Open();
        }

        [TestCleanup]
        public void TestCleanup() => _connection.Dispose();
        
        [TestMethod]
        public void Test_CreateTable_SQLite()
        {
            if (!_connection.IsTarget(TargetDB.SQLite)) return;

            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                CreateTable(db.table3,
                    new Column(db.table3.obj1, DataType.Int()),
                    new Column(db.table3.obj2, DataType.Integer()),
                    new Column(db.table3.obj3, DataType.TinyInt()),
                    new Column(db.table3.obj4, DataType.SmallInt()),
                    new Column(db.table3.obj5, DataType.MediumInt()),
                    new Column(db.table3.obj6, DataType.BigInt()),
                    new Column(db.table3.obj7, DataType.UnsignedBigInt()),
                    new Column(db.table3.obj8, DataType.Int2()),
                    new Column(db.table3.obj9, DataType.Int8()),
                    new Column(db.table3.obj10, DataType.Character(1)),
                    new Column(db.table3.obj11, DataType.VarChar(1)),
                    new Column(db.table3.obj12, DataType.VaryingCharacter(1)),
                    new Column(db.table3.obj13, DataType.NChar(1)),
                    new Column(db.table3.obj14, DataType.NativeCharacter(1)),
                    new Column(db.table3.obj15, DataType.NVarChar()),
                    new Column(db.table3.obj16, DataType.Text()),
                    new Column(db.table3.obj17, DataType.Clob()),
                    new Column(db.table3.obj18, DataType.Blob()),
                    new Column(db.table3.obj19, DataType.Real()),
                    new Column(db.table3.obj20, DataType.Double()),
                    new Column(db.table3.obj21, DataType.DoublePrecision()),
                    new Column(db.table3.obj22, DataType.Float()),
                    new Column(db.table3.obj23, DataType.Numeric()),
                    new Column(db.table3.obj24, DataType.Decimal()),//(10, 5)
                    new Column(db.table3.obj25, DataType.Boolean()),
                    new Column(db.table3.obj26, DataType.Date()),
                    new Column(db.table3.obj27, DataType.DateTime())
                ));

            _connection.Execute(sql);
        }
        
        void CleanUpCreateDropTestTable()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table3));
                _connection.Execute(sql);
            }
            catch { }
        }
    }
}
