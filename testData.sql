SET NAMES 'utf8';

insert appuser (name,login) values ('Иванов И.И.','ivanovii');

insert classifier(name) values('Вкусная булочка');
insert barcode (classifier_id,code) values(LAST_INSERT_ID(),'2500000195351');
insert product (classifier_id,price) values(LAST_INSERT_ID(),2542300);
insert productonstore (product_id, amount) values (LAST_INSERT_ID(),3);


insert classifier(name) values('Замечательный пирожок');
insert barcode (classifier_id,code) values(LAST_INSERT_ID(),'2500000195361');
insert product (classifier_id,price) values(LAST_INSERT_ID(),5343200);
insert productonstore (product_id, amount) values (LAST_INSERT_ID(),22);


insert classifier(name) values('Мороженное "Пальчики оближешь"');
insert barcode (classifier_id,code) values(LAST_INSERT_ID(),'2500000195371');
insert product (classifier_id,price) values(LAST_INSERT_ID(),542500);
insert productonstore (product_id, amount) values (LAST_INSERT_ID(),36);

insert classifier(name) values('Эскимо');
insert barcode (classifier_id,code) values(LAST_INSERT_ID(),'2500000195381');
insert product (classifier_id,price) values(LAST_INSERT_ID(),300000);
insert productonstore (product_id, amount) values (LAST_INSERT_ID(),20);

