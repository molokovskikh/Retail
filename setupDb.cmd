@rem Создание БД и таблиц
@rem Установите переменную окружения PATH в соответсвии с вашей установкой MySql
@rem set PATH=%PATH%;C:\Program Files (x86)\MySQL\MySQL Server 5.7\bin
mysql -u root -p < createDb.sql
mysql --user=admin_retail --password=admin_retail retail < createTables.sql