// Interface = Aggreement = CanAbleTo(Birşey yapabilme yeteneği)
using Abbstrack_ve_Interface;

var sqlDb = new SqlServerDb();
sqlDb.ExecuteSql("");

var oracleDb = new OracleDb();
oracleDb.ExecuteSql("");

var mysqlDb = new MySqlDb();
mysqlDb.ExecuteSql("");
mysqlDb.GetDbVersion();


//var baseDb = new BaseDb();            soyutlaştırma ve ortaklaştırma yaptık
//baseDb.ExecuteSql("");                 abstract tanımlı olduğundan nesne tanımlayamıyoruz


var araba = new VehicleTestMethods.Car();
araba.go();
araba.stop();

var ucak = new VehicleTestMethods.Plane();
ucak.go();
ucak.Soar();
ucak.stop();

var bisiklet = new VehicleTestMethods.Bike();
bisiklet.go();
bisiklet.Ride();
bisiklet.stop();

