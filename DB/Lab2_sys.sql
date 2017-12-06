select * from representative_t;

select representative, categorie, descripe 
	from representative_t inner join categorie_t 
		on representative_t.id_categorie=categorie_t.id_categorie;

select representative, categorie, descripe
	from representative_t inner join categorie_t 
		on categorie='A';

select id_representative, representative
	from representative_t
		where id_representative=1;

insert 
	into categorie_t (categorie, descripe) 
	values ('A1','Motorcycles with a working volume of the engine, not exceeding 125 cu. Cm, and a maximum power not exceeding 11 kW.');

insert
	into representative_t (representative, id_categorie)
	values ('Suzuki GSX-1300R',3);

update representative_t
set representative='Husqvarna SMR-510', id_categorie=2;

delete from representative_t 
	where id_representative=1;
