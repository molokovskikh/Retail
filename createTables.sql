-- Пользователь приложения
CREATE TABLE IF NOT EXISTS appuser
(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
login VARCHAR(300),
name VARCHAR(300)
);

-- Документ
CREATE TABLE IF NOT EXISTS document
(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
typedoc VARCHAR(50),
statusdoc VARCHAR(50)
);

-- Номенклатура товара
CREATE TABLE IF NOT EXISTS classifier 
(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
name VARCHAR(300)
);

-- Товар
CREATE TABLE IF NOT EXISTS product 
(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
classifier_id int NOT NULL,
price BIGINT NOT NULL
);

-- Товары поступившие на склад
CREATE TABLE IF NOT EXISTS productonstore 
(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
product_id INT NOT NULL,
amount BIGINT NOT NULL
);

-- Проданные товары
CREATE TABLE IF NOT EXISTS saleofproduct 
(
id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
document_id INT NOT NULL,
product_id INT NOT NULL,
amount BIGINT NOT NULL
);

-- Штрих-код товаров
CREATE TABLE IF NOT EXISTS barcode
(
classifier_id INT NOT NULL,
code VARCHAR(64) NOT NULL
);

-- Дефектура о номенклатуре товаров
CREATE TABLE IF NOT EXISTS defectura
(
classifier_id INT NOT NULL PRIMARY KEY,
value BIGINT NOT NULL
);



-- Поисковые индексы для быстрого поиска
CREATE INDEX idx_name ON classifier(name);

CREATE INDEX idx_barcode ON barcode(code);

-- Внешние ключи между таблицами
ALTER TABLE product
ADD CONSTRAINT FOREIGN KEY (classifier_id) REFERENCES classifier(id);

ALTER TABLE barcode
ADD CONSTRAINT FOREIGN KEY (classifier_id) REFERENCES classifier(id);

ALTER TABLE defectura
ADD CONSTRAINT FOREIGN KEY (classifier_id) REFERENCES classifier(id);

ALTER TABLE productonstore
ADD CONSTRAINT FOREIGN KEY (product_id) REFERENCES product(id);

ALTER TABLE saleofproduct
ADD CONSTRAINT FOREIGN KEY (product_id) REFERENCES product(id);

ALTER TABLE saleofproduct
ADD CONSTRAINT FOREIGN KEY (document_id) REFERENCES document(id);

-- Все значения цен и количества 
-- хранятся в BIGINT и в визуально представлении кратны 10000, что соответсвует 4 знаку после запятой
-- Пример 25,4783 в БД хранится как 25,4783
-- В свою очередь 4751000 в представлении прикладной логики будет иметь значение 475,1
-- БД| 431224545456 => 43122454,5456  |Интерфейс пользователя
-- Интерфейс пользователя|  100,05 сто рублей пять копеек =>  1000500 |БД