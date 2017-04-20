CREATE USER IF NOT EXISTS 'admin_retail'@'localhost' IDENTIFIED BY 'admin_retail';

CREATE DATABASE IF NOT EXISTS retail;

GRANT ALL PRIVILEGES ON retail.* TO 'admin_retail'@'localhost';