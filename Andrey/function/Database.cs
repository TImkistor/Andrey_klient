

using MySqlConnector;
using System.Data;

namespace Andrey
{
    static class Database
    {
        static MySqlConnection connectionSec = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
        static MySqlConnection connectionFil = new MySqlConnection("server=127.0.0.1;database=torg; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");

        /// <summary>a
        /// Sec table
        /// </summary>
        /// <returns></returns>
        public static DataTable SECURITY()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_SEC`, `FIO` AS `ФИО`, `FIONepolnoe` AS `Сокращено` , `Dolg` AS `Должность` , `Login` AS `Логин`, `Password` AS `Пароль` , `level` AS `Уровень`,`Mesto` AS `Место` FROM `sec`"
          , connectionSec);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }

        /// <summary>
        /// Мероприятия table
        /// </summary>
        /// <returns></returns>
        public static DataTable CLIENT()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Client`, client.FIO AS `ФИО`, client.ADDRES AS `Адрес`, client.KONTAKT AS `Контакт` FROM client", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable TIP()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Tip`, tip.Naim AS `Название` FROM tip", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable PRODUCT()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Product`, product.Naim AS `Название`, postavshik.Naim AS `Поставщик` FROM product INNER JOIN postavshik ON product.ID_Postavshik = postavshik.ID_Postavshik", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable POSTAVSHIK()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Postavshik`, postavshik.Naim AS `Название`, rab.FIO AS `Работник`, postavshik.Kolvo AS `Кол-во` FROM postavshik INNER JOIN rab ON postavshik.ID_Rab = rab.ID_Rab", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable RAB()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Rab`, rab.FIO AS `ФИО`, rab.DOLG AS `Должность`, rab.KONTAKT AS `Контакт` FROM rab", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable MAGAZINE()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Magaz`, magaz.Naim AS `Название`, tip.Naim AS `Тип`, rab.FIO AS `Работник`, product.Naim AS `Продукт`, client.FIO AS `Клиент` FROM magaz INNER JOIN tip ON magaz.ID_Tip = tip.ID_Tip INNER JOIN rab ON magaz.ID_Rab = rab.ID_Rab INNER JOIN product ON magaz.ID_Product = product.ID_Product  INNER JOIN client ON magaz.ID_Client = client.ID_Client", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }

    }
}
