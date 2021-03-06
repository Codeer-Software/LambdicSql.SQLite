﻿using System;
using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.SQLite.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;
using static Test.TestSymbol;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesSelect
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

        public class SelectData
        {
            public DateTime PaymentDate { get; set; }
            public decimal Money { get; set; }
        }

        [TestMethod]
        public void Test_selected()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new SelectData
                {
                    PaymentDate = db.tbl_remuneration.payment_date,
                    Money = db.tbl_remuneration.money,
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.payment_date AS PaymentDate,
	tbl_remuneration.money AS Money
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_before_selected()
        {
            var sql = Db<DB>.Sql(db =>
                Empty().
                Select(new SelectData
                {
                    PaymentDate = db.tbl_remuneration.payment_date,
                    Money = db.tbl_remuneration.money,
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_remuneration.payment_date AS PaymentDate,
	tbl_remuneration.money AS Money
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_asterisk()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_before_asterisk()
        {
            var sql = Db<DB>.Sql(db =>
                Empty().
                Select(Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_asteriskT()
        {
            var sql = Db<DB>.Sql(db =>
                Select(Asterisk(db.tbl_remuneration)).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_before_asteriskT()
        {
            var sql = Db<DB>.Sql(db =>
                Empty().
                Select(Asterisk(db.tbl_remuneration)).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_predicate_selected()
        {
            var sql = Db<DB>.Sql(db =>
                Select(All(), new SelectData
                {
                    PaymentDate = db.tbl_remuneration.payment_date,
                    Money = db.tbl_remuneration.money,
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT ALL
	tbl_remuneration.payment_date AS PaymentDate,
	tbl_remuneration.money AS Money
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_before_predicate_selected()
        {
            var sql = Db<DB>.Sql(db =>
                Empty().
                Select(Distinct(), new SelectData
                {
                    PaymentDate = db.tbl_remuneration.payment_date,
                    Money = db.tbl_remuneration.money,
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT DISTINCT
	tbl_remuneration.payment_date AS PaymentDate,
	tbl_remuneration.money AS Money
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_predicate_astrisk()
        {
            var sql = Db<DB>.Sql(db =>
                Select(All(), Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT ALL *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_before_predicate_astrisk()
        {
            var sql = Db<DB>.Sql(db =>
                Empty().
                Select(Distinct(), Asterisk()).
                From(db.tbl_remuneration));

            var datas = _connection.Query<Remuneration>(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT DISTINCT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_predicate_astriskT()
        {
            var sql = Db<DB>.Sql(db =>
                Select(All(), Asterisk<Remuneration>()).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT ALL *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_before_predicate_astriskT()
        {
            var sql = Db<DB>.Sql(db =>
                Empty().
                Select(Distinct(), Asterisk<Remuneration>()).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT DISTINCT *
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_SubQuery_1()
        {
            var sub = Db<DB>.Sql(db =>
                Select(Sum(db.tbl_remuneration.money)).
                From(db.tbl_remuneration));
            
            var sql = Db<DB>.Sql(db =>
                Select(new SelectData
                {
                    Money = sub
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	(SELECT
		SUM(tbl_remuneration.money)
	FROM tbl_remuneration) AS Money
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_SubQuery_2()
        {
            var sql = Db<DB>.Sql(db =>
                Select(new SelectData
                {
                    Money = Select(Sum(db.tbl_remuneration.money)).
                                From(db.tbl_remuneration)
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	(SELECT
		SUM(tbl_remuneration.money)
	FROM tbl_remuneration) AS Money
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_SubQuery_Empty()
        {
            var sub = new Sql<decimal>();

            var sql = Db<DB>.Sql(db =>
                Select(new SelectData
                {
                    PaymentDate = db.tbl_remuneration.payment_date,
                    Money = sub
                }).
                From(db.tbl_remuneration));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count); AssertEx.AreEqual(sql, _connection,
 @"SELECT
	tbl_remuneration.payment_date AS PaymentDate
FROM tbl_remuneration");
        }

        [TestMethod]
        public void Test_Single_1()
        {
            var sql = Db<DB>.Sql(db => Select(db.tbl_staff.id).From(db.tbl_staff));
            
            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	tbl_staff.id
FROM tbl_staff");
        }

        [TestMethod]
        public void Test_Single_2()
        {
            var sql = Db<DB>.Sql(db => Select(Count(Asterisk())).From(db.tbl_staff));

            var datas = _connection.Query(sql).ToList();
            Assert.IsTrue(0 < datas.Count);
            AssertEx.AreEqual(sql, _connection,
@"SELECT
	COUNT(*)
FROM tbl_staff");
        }
    }
}
