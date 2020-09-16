--Zadatak 4- Baza podataka ODRZAVANJE PUTEVA--
----------------------------------------------
---------- Vladeta Manic 16171 ---------------
---------- Kristijan Ilic 16103 --------------
---------- Djordje Djorovic 16083 ------------
----------------------------------------------
DROP TABLE "PREDUZECE" cascade constraints;
DROP TABLE "IZVRSILAC" cascade constraints;
DROP TABLE "NADZORNIK" cascade constraints;
DROP TABLE "RADNIK" cascade constraints;
DROP TABLE "VOZILO" cascade constraints;
DROP TABLE "PUTNICKO" cascade constraints;
DROP TABLE "TERETNO" cascade constraints;
DROP TABLE "RADNA_MASINA" cascade constraints;
DROP TABLE "GRADILISTE" cascade constraints;
DROP TABLE "DEONICA" cascade constraints;
DROP TABLE "SPOLJNI_SARADNIK" cascade constraints;
DROP TABLE "DUZI" cascade constraints;
DROP TABLE "UPRAVLJA" cascade constraints;
DROP TABLE "RADI_NA" cascade constraints;
DROP TABLE "TERETNO_ANGAZOVANO" cascade constraints;
DROP TABLE "RADMAS_ANGAZOVANA" cascade constraints;

DROP SEQUENCE "ID_RADNIK_SEQ";
DROP SEQUENCE "ID_PREDUZECE_SEQ";
DROP SEQUENCE "ID_GRADILISTE_SEQ";
DROP SEQUENCE "ID_DEONICE_SEQ";
DROP SEQUENCE "BROJ_UGOVORA_O_DELU_SEQ";

DROP TRIGGER "RADNIK_AUTO_PK";
DROP TRIGGER "PREDUZECE_AUTO_PK";
DROP TRIGGER "GRADILISTE_AUTO_PK";
DROP TRIGGER "DEONICA_AUTO_PK";
DROP TRIGGER "BROJ_UGOVORA_O_DELU_AUTO_PK";

-------------------++++++++++++++++---------------------

--------------------------------------------------------
--------------------------------------------------------
---------------------SEQUENCES DDL----------------------
--------------------------------------------------------
--------------------------------------------------------



--------------------------------------------------------
--  DDL for Sequence ID_RADNIKA_SEQ
--------------------------------------------------------

CREATE SEQUENCE "ID_RADNIK_SEQ" MINVALUE 1 MAXVALUE 99999 INCREMENT BY 1 START WITH 20 CACHE 20 ORDER NOCYCLE;


--------------------------------------------------------
--  DDL for Sequence ID_PREDUZECE_SEQ
--------------------------------------------------------

CREATE SEQUENCE "ID_PREDUZECE_SEQ" MINVALUE 1 MAXVALUE 99999 INCREMENT BY 1 START WITH 20 CACHE 20 ORDER NOCYCLE;


--------------------------------------------------------
--  DDL for Sequence ID_GRADILISTE_SEQ
--------------------------------------------------------

CREATE SEQUENCE "ID_GRADILISTE_SEQ" MINVALUE 1 MAXVALUE 99999 INCREMENT BY 1 START WITH 20 CACHE 20 ORDER NOCYCLE;


--------------------------------------------------------
--  DDL for Sequence ID_DEONICE_SEQ
--------------------------------------------------------

CREATE SEQUENCE "ID_DEONICE_SEQ" MINVALUE 1 MAXVALUE 99999 INCREMENT BY 1 START WITH 20 CACHE 20 ORDER NOCYCLE;



--------------------------------------------------------
--  DDL for Sequence BROJ_UGOVORA_O_DELU_SEQ
--------------------------------------------------------


CREATE SEQUENCE "BROJ_UGOVORA_O_DELU_SEQ" MINVALUE 1 MAXVALUE 99999 INCREMENT BY 1 START WITH 20 CACHE 20 ORDER NOCYCLE;



--------------------------------------------------------
--------------------------------------------------------
----------------------TABLES DDL------------------------
--------------------------------------------------------
--------------------------------------------------------



--------------------------------------------------------
--  DDL for Table PREDUZECE
--------------------------------------------------------
CREATE TABLE PREDUZECE
(
NAZIV         VARCHAR2(20),
ID         NUMBER
);


--------------------------------------------------------
--  DDL for Table RADNIK
--------------------------------------------------------
CREATE TABLE RADNIK
(
ID_RADNIK NUMBER,
JMBG         NUMBER,
IME         VARCHAR2(15),
PREZIME         VARCHAR2(15),
OCEVO_IME         VARCHAR2(15),
GODINA_RODJ         NUMBER,
ADRESA         VARCHAR2(20),
ID_PREDUZECE         NUMBER,
ID_NADREDJENI         NUMBER
);


--------------------------------------------------------
--  DDL for Table NADZORNIK
--------------------------------------------------------
CREATE TABLE NADZORNIK
(
DATUM_POSTAVLJANJA         DATE,
ID_RADNIK         NUMBER
);


--------------------------------------------------------
--  DDL for Table IZVRSILAC
--------------------------------------------------------
CREATE TABLE IZVRSILAC
(
ID_RADNIK         	NUMBER,
SPECIJALNOST		 VARCHAR2(15)
);


--------------------------------------------------------
--  DDL for Table VOZILO
--------------------------------------------------------
CREATE TABLE VOZILO
(
REG_OZNAKA         VARCHAR2(15),
GORIVO         VARCHAR2(15),
ZAPREMINA_MOTORA         NUMBER,
BOJA         VARCHAR2(15)
);



--------------------------------------------------------
--  DDL for Table PUTNICKO
--------------------------------------------------------
CREATE TABLE PUTNICKO
(
BROJ_MESTA         NUMBER,
REG_OZNAKA         VARCHAR2(15)
);


--------------------------------------------------------
--  DDL for Table TERETNO
--------------------------------------------------------
CREATE TABLE TERETNO
(
BROJ_OSOVINA         NUMBER,
NOSIVOST         NUMBER,
REG_OZNAKA         VARCHAR2(15)
);


--------------------------------------------------------
--  DDL for RADNA_MASINA
--------------------------------------------------------
CREATE TABLE RADNA_MASINA
(
TIP_POGONA         VARCHAR2(15),
TIP         VARCHAR2(15),
REG_OZNAKA         VARCHAR2(15)
);

 
--------------------------------------------------------
--  DDL for Table GRADILISTE
--------------------------------------------------------
CREATE TABLE GRADILISTE
(
ID_GRADILISTA         NUMBER,
TIP 				  VARCHAR2(15),
ID_PREDUZECE 		  NUMBER
);

--------------------------------------------------------
--  DDL for Table SPOLJNI_SARADNIK
--------------------------------------------------------
CREATE TABLE SPOLJNI_SARADNIK
(
BROJ_UGOVORA_O_DELU         NUMBER,
ID_NADZORNIKA         NUMBER
);

--------------------------------------------------------
--  DDL for Table DEONICA
--------------------------------------------------------
CREATE TABLE DEONICA
(
KRAJNJI_GRAD         VARCHAR(15),
POCETNI_GRAD         VARCHAR(15),
POCETNI_KM         NUMBER,
ZAVRSNI_KM         NUMBER,
ID_DEONICE         NUMBER,
ID_GRADILISTA         NUMBER
);


--------------------------------------------------------
--  DDL for Table DUZI
--------------------------------------------------------
CREATE TABLE DUZI(
ID_RADNIK         NUMBER,
REG_OZNAKA         VARCHAR2(15),
DATUM_OD         DATE,
DATUM_DO         DATE
);

--------------------------------------------------------
--  DDL for Table UPRAVLJA
--------------------------------------------------------
CREATE TABLE UPRAVLJA(

ID_RADNIK         NUMBER,
REG_OZNAKA         VARCHAR2(15),
DATUM_OD         DATE,
DATUM_DO         DATE
);

--------------------------------------------------------
--  DDL for Table RADI_NA
--------------------------------------------------------
CREATE TABLE RADI_NA(
ID_RADNIK         NUMBER,
ID_DEONICE         NUMBER,
DATUM_OD         DATE,
DATUM_DO         DATE

);


--------------------------------------------------------
--  DDL for Table TERETNO_ANGAZOVANO
--------------------------------------------------------
CREATE TABLE TERETNO_ANGAZOVANO(
ID_DEONICE         NUMBER,
REG_OZNAKA         VARCHAR2(15),
DATUM_OD         DATE,
DATUM_DO         DATE

);


--------------------------------------------------------
--  DDL FOR TABLE RADMAS_ANGAZOVANA
--------------------------------------------------------
CREATE TABLE RADMAS_ANGAZOVANA(
ID_DEONICE         NUMBER,
REG_OZNAKA         VARCHAR2(15),
DATUM_OD         DATE,
DATUM_DO         DATE

);


--/*
-- VREDNOSTI ZA PREDUZECE

INSERT INTO PREDUZECE VALUES('Bela ladja',1);


-- VREDNOSTI ZA RADNIK

INSERT INTO RADNIK VALUES(1,3012993730051, 'Ognjen', 'Petrovic','Marko',1956,'Cvijiceva',1, NULL);
INSERT INTO RADNIK VALUES(2,1711994731316, 'Nemanja','Nikolic','Milos',1966,'Proleterska',1, NULL);
INSERT INTO RADNIK VALUES(3,1208994757012, 'Marija','Marinkovic','Miloje',1997,'Pobedina',1,1);
INSERT INTO RADNIK VALUES(4,1202989735010, 'Ana' ,'Manic' ,'Kristijan', 1988, 'Cvetna',1,2);
INSERT INTO RADNIK VALUES(5,1904994735003, 'Aleksandar' ,'Jovanovic','Djordje', 1989, 'Cvetna',1,2);
INSERT INTO RADNIK VALUES(6,2107994731052, 'Stefan' ,'Stamenovic','Vladimir', 1925, 'Udarnicka',1,1);
INSERT INTO RADNIK VALUES(7,3012978735024, 'Petar' ,'Zivkovic','Zoran', 1991, 'Rasadnicka',1,2);
INSERT INTO RADNIK VALUES(8,0406993734325, 'Dusan' ,'Lilic','Zoran', 1995, 'Cvetna',1,1);
INSERT INTO RADNIK VALUES(9,1207994424325, 'Nikola' ,'Berdic','Aleksa', 1969, 'Prvomajska',1,2);
INSERT INTO RADNIK VALUES(10,1903994735016, 'Milica' ,'Milovanovic','Milos', 1948, 'Cvijiceva',1,1);
INSERT INTO RADNIK VALUES(11,0110994473139, 'Stefan' ,'Stamenkovic','Kristijan', 1975, 'Cvetna',1,1);
INSERT INTO RADNIK VALUES(12,2106994730007, 'Stefan' ,'Djokic','Petar', 1985, 'Svetogorska',1,1);
INSERT INTO RADNIK VALUES(13,2207994730064, 'Stojan' ,'Cvetanovic','Vladan', 1978, 'Svetogorska',1,1);
INSERT INTO RADNIK VALUES(14,1408994720079, 'Stefan' ,'Petrovic','Nemanja', 1976, 'Udarnicka',1,2);
INSERT INTO RADNIK VALUES(15,1008998473584, 'Darko' ,'Lazetic','Lazar', 1966, 'Zanatska',1,2);


-- VREDNOSTI ZA NADZORNIK

INSERT INTO NADZORNIK VALUES('24-DEC-2006',1);
INSERT INTO NADZORNIK VALUES('30-DEC-2005',5);
INSERT INTO NADZORNIK VALUES('23-JUN-2018',7);
INSERT INTO NADZORNIK VALUES('3-JUN-2015',8);
INSERT INTO NADZORNIK VALUES('30-JAN-2011',10);



-- VREDNOSTI ZA IZVRSILAC

INSERT INTO IZVRSILAC VALUES(2,'vozac');
INSERT INTO IZVRSILAC VALUES(3,'vozac bagera');
INSERT INTO IZVRSILAC VALUES(4,'vozac valjka');
INSERT INTO IZVRSILAC VALUES(6,'vozac traktora');
INSERT INTO IZVRSILAC VALUES(9,'vozac kamiona');
INSERT INTO IZVRSILAC VALUES(11,'vozac');
INSERT INTO IZVRSILAC VALUES(12,'vozac kamiona');
INSERT INTO IZVRSILAC VALUES(13,'vozac kamiona');
INSERT INTO IZVRSILAC VALUES(14,'vozac kamiona');
INSERT INTO IZVRSILAC VALUES(15,'vozac valjka');


-- VREDNOSTI ZA VOZILO

INSERT INTO VOZILO  VALUES ('NI-001-01','DIZEL',2000,'zuta');
INSERT INTO VOZILO  VALUES ('NI-333-33','DIZEL',3000,'crna');
INSERT INTO VOZILO  VALUES ('NI-052-03','DIZEL',2500,'zelena');
INSERT INTO VOZILO  VALUES ('NI-652-56','BENZIN',2500,'crna');
INSERT INTO VOZILO  VALUES ('NI-886-66','DIZEL',5000,'bela');
INSERT INTO VOZILO  VALUES ('NI-003-45','DIZEL',2000,'crvena');
INSERT INTO VOZILO  VALUES ('NI-585-78','BENZIN',2000,'siva');
INSERT INTO VOZILO  VALUES ('NI-888-55','DIZEL',3000,'zuta');
INSERT INTO VOZILO  VALUES ('NI-888-66','DIZEL',5000,'zuta');
INSERT INTO VOZILO  VALUES ('NI-886-67','BENZIN',2500,'zuta');

-- VREDNOSTI ZA PUTNICKO

INSERT INTO PUTNICKO VALUES(5,'NI-001-01');
INSERT INTO PUTNICKO VALUES(5,'NI-652-56');
INSERT INTO PUTNICKO VALUES(5,'NI-886-66');

-- VREDNOSTI ZA TERETNO

INSERT INTO TERETNO VALUES (3,4,'NI-333-33');
INSERT INTO TERETNO VALUES (4,4,'NI-052-03');
INSERT INTO TERETNO VALUES (5,6,'NI-888-55');
INSERT INTO TERETNO VALUES (5,7,'NI-003-45');

-- VREDNOSTI ZA RADNA_MASINA

INSERT INTO RADNA_MASINA VALUES('GUSENICAR','bager','NI-585-78');
INSERT INTO RADNA_MASINA VALUES('TOCKAS','traktor','NI-888-66');



-- VREDNOSTI ZA GRADILISTE

INSERT INTO GRADILISTE VALUES(1,'IZGRADNJA',1);
INSERT INTO GRADILISTE VALUES(2,'REKONSTRUKCIJA',1);
INSERT INTO GRADILISTE VALUES(3,'REKONSTRUKCIJA',1);
INSERT INTO GRADILISTE VALUES(4,'IZGRADNJA',1);
INSERT INTO GRADILISTE VALUES(5,'IZGRADNJA',1);


-- VREDNOSTI ZA SPOLJNI_SARADNIK

INSERT INTO SPOLJNI_SARADNIK VALUES (15,1);
INSERT INTO SPOLJNI_SARADNIK VALUES (26,7);

-- VREDNOSTI ZA DEONICA

INSERT INTO DEONICA VALUES('Nis','Pirot',30,150,1,1);
INSERT INTO DEONICA VALUES('Nis','Beograd',80,256,2,3);
INSERT INTO DEONICA VALUES('Pirot','Pec',120,320,3,5);
INSERT INTO DEONICA VALUES('Pirot','Novi Sad',20,156,4,3);
INSERT INTO DEONICA VALUES('Subotica','Leskova',150,222,5,4);
INSERT INTO DEONICA VALUES('Nis','Barselona',300,620,6,2);
INSERT INTO DEONICA VALUES('Pristina','Kragujevac',250,560,7,5);
INSERT INTO DEONICA VALUES('Pristina','Atina',56,256,8,5);

-- VREDNOSTI ZA DUZI

INSERT INTO DUZI VALUES (5,'NI-001-01',to_date('19.04.2018','DD.MM.RRRR'),to_date('07.09.2018','DD.MM.RRRR'));
INSERT INTO DUZI VALUES (7,'NI-001-01',to_date('12.10.2016','DD.MM.RRRR'),to_date('17.12.2016','DD.MM.RRRR'));
INSERT INTO DUZI VALUES (8,'NI-652-56',to_date('11.06.2017','DD.MM.RRRR'),to_date('16.07.2017','DD.MM.RRRR'));
INSERT INTO DUZI VALUES (10,'NI-886-66',to_date('28.3.2018','DD.MM.RRRR'),to_date('02.06.2018','DD.MM.RRRR'));
INSERT INTO DUZI VALUES (1,'NI-652-56',to_date('30.08.2016','DD.MM.RRRR'),to_date('08.9.2016','DD.MM.RRRR'));

-- VREDNOSTI ZA UPRAVLJA

INSERT INTO UPRAVLJA VALUES (2,'NI-333-33',to_date('19.04.2018','DD.MM.RRRR'),to_date('07.09.2018','DD.MM.RRRR'));
INSERT INTO UPRAVLJA VALUES (3,'NI-888-55',to_date('12.10.2016','DD.MM.RRRR'),to_date('17.12.2016','DD.MM.RRRR'));
INSERT INTO UPRAVLJA VALUES (6,'NI-888-66',to_date('11.06.2017','DD.MM.RRRR'),to_date('16.07.2017','DD.MM.RRRR'));
INSERT INTO UPRAVLJA VALUES (12,'NI-652-56',to_date('20.09.2018','DD.MM.RRRR'),to_date('30.9.2018','DD.MM.RRRR'));

-- VREDNOSTI ZA RADI_NA

INSERT INTO RADI_NA  VALUES (4,6,to_date('12.03.2018','DD.MM.RRRR'),to_date('07.05.2018','DD.MM.RRRR'));
INSERT INTO RADI_NA  VALUES (6,4,to_date('30.01.2017','DD.MM.RRRR'),to_date('07.01.2017','DD.MM.RRRR'));
INSERT INTO RADI_NA  VALUES (9,3,to_date('20.07.2017','DD.MM.RRRR'),to_date('13.10.2017','DD.MM.RRRR'));
INSERT INTO RADI_NA  VALUES (15,5,to_date('28.10.2015','DD.MM.RRRR'),to_date('28.11.2015','DD.MM.RRRR'));

--VREDNOSTI ZA TERETNO_ANGAZOVANO

INSERT INTO TERETNO_ANGAZOVANO  VALUES (1,'NI-333-33',to_date('11.01.2013','DD.MM.RRRR'),to_date('01.04.2018','DD.MM.RRRR'));
INSERT INTO TERETNO_ANGAZOVANO  VALUES (2,'NI-052-03',to_date('12.02.2014','DD.MM.RRRR'),to_date('02.05.2018','DD.MM.RRRR'));
INSERT INTO TERETNO_ANGAZOVANO  VALUES (3,'NI-888-55',to_date('13.03.2015','DD.MM.RRRR'),to_date('03.06.2018','DD.MM.RRRR'));
INSERT INTO TERETNO_ANGAZOVANO  VALUES (4,'NI-003-45',to_date('14.04.2016','DD.MM.RRRR'),to_date('04.07.2018','DD.MM.RRRR'));


--VREDNOSTI ZA RADMAS_ANGAZOVANA

INSERT INTO RADMAS_ANGAZOVANA  VALUES (1,'NI-585-78',to_date('15.05.2013','DD.MM.RRRR'),to_date('05.08.2018','DD.MM.RRRR'));
INSERT INTO RADMAS_ANGAZOVANA  VALUES (2,'NI-888-66',to_date('16.06.2014','DD.MM.RRRR'),to_date('06.09.2018','DD.MM.RRRR'));








--------------------------------------------------------
--------------------------------------------------------
----------------------CONSTRAINTS-----------------------
--------------------------------------------------------
--------------------------------------------------------



--------------------------------------------------------
--  Constraints for Table PREDUZECE
--------------------------------------------------------
 
  ALTER TABLE "PREDUZECE" ADD CONSTRAINT "PREDUZECE_PK" PRIMARY KEY ("ID") ENABLE;
 
--------------------------------------------------------
--  Constraints for Table RADNIK
--------------------------------------------------------

  ALTER TABLE "RADNIK" ADD CONSTRAINT "RADNIK_PK" PRIMARY KEY ("ID_RADNIK") ENABLE;

--------------------------------------------------------  
--  Constraints for Table GRADILISTE
--------------------------------------------------------

  ALTER TABLE "GRADILISTE" ADD CONSTRAINT "GRADILISTE_PK" PRIMARY KEY ("ID_GRADILISTA") ENABLE;
  ALTER TABLE "GRADILISTE" ADD CONSTRAINT "TIP_GRADILISTA_CHK" CHECK (TIP IN ('IZGRADNJA','REKONSTRUKCIJA')) ENABLE;

--------------------------------------------------------
--  Constraints for Table IZVRSILAC
--------------------------------------------------------

  ALTER TABLE "IZVRSILAC" ADD CONSTRAINT "IZVRSILAC_PK" PRIMARY KEY ("ID_RADNIK") ENABLE;

--------------------------------------------------------
--  Constraints for Table NADZORNIK
--------------------------------------------------------

  ALTER TABLE "NADZORNIK" ADD CONSTRAINT "NADZORNIK_PK" PRIMARY KEY ("ID_RADNIK") ENABLE;
 
--------------------------------------------------------
--  Constraints for Table VOZILO
--------------------------------------------------------
 
  ALTER TABLE "VOZILO" ADD CONSTRAINT "VOZILO_PK" PRIMARY KEY ("REG_OZNAKA") ENABLE;
  ALTER TABLE "VOZILO" ADD CONSTRAINT "TIP_GORIVA_CHK" CHECK (GORIVO IN ('DIZEL','BENZIN')) ENABLE;
--------------------------------------------------------
--  Constraints for Table PUTNICKO
--------------------------------------------------------

  ALTER TABLE "PUTNICKO" ADD CONSTRAINT "PUTNICKO_PK" PRIMARY KEY ("REG_OZNAKA") ENABLE;
 
--------------------------------------------------------
--  Constraints for Table TERETNO
--------------------------------------------------------

  ALTER TABLE "TERETNO" ADD CONSTRAINT "TERETNO_PK" PRIMARY KEY ("REG_OZNAKA") ENABLE;
 
--------------------------------------------------------
--  Constraints for Table RADNA_MASINA
--------------------------------------------------------

  ALTER TABLE "RADNA_MASINA" ADD CONSTRAINT "RADNA_MASINA_PK" PRIMARY KEY ("REG_OZNAKA") ENABLE;
 ALTER TABLE "RADNA_MASINA" ADD CONSTRAINT "TIP_POGONA_CHK" CHECK (TIP_POGONA IN ('TOCKAS','GUSENICAR')) ENABLE;
 
 --------------------------------------------------------
--  Constraints for Table SPOLJNI_SARADNIK
--------------------------------------------------------

  ALTER TABLE "SPOLJNI_SARADNIK" ADD CONSTRAINT "SPOLJNI_SARADNIK_PK" PRIMARY KEY ("BROJ_UGOVORA_O_DELU","ID_NADZORNIKA") ENABLE;
 
 --------------------------------------------------------
--  Constraints for Table DEONICA
--------------------------------------------------------

 ALTER TABLE "DEONICA" ADD CONSTRAINT "DEONICA_PK" PRIMARY KEY ("ID_DEONICE") ENABLE;
 
--------------------------------------------------------
--  Constraints for Table DUZI
--------------------------------------------------------

  ALTER TABLE "DUZI" ADD CONSTRAINT "DUZI_PK" PRIMARY KEY ("ID_RADNIK","REG_OZNAKA") ENABLE;

--------------------------------------------------------
--  Constraints for Table UPRAVLJA !!!!!!DODATO!!!!!!
--------------------------------------------------------

  ALTER TABLE "UPRAVLJA" ADD CONSTRAINT "UPRAVLJA_PK" PRIMARY KEY ("ID_RADNIK","REG_OZNAKA") ENABLE;
  --------------------------------------------------------
--  Constraints for Table RADI_NA
--------------------------------------------------------

  ALTER TABLE "RADI_NA" ADD CONSTRAINT "RADI_NA_PK" PRIMARY KEY ("ID_RADNIK","ID_DEONICE") ENABLE;

  --------------------------------------------------------
--  Constraints for Table TERETNO_ANGAZOVANO
--------------------------------------------------------

  ALTER TABLE "TERETNO_ANGAZOVANO" ADD CONSTRAINT "TERETNO_ANGAZOVANO_PK" PRIMARY KEY ("REG_OZNAKA","ID_DEONICE") ENABLE;
 
  --------------------------------------------------------
--  Constraints for Table RADMAS_ANGAZOVANA
--------------------------------------------------------

  ALTER TABLE "RADMAS_ANGAZOVANA" ADD CONSTRAINT "RADMAS_ANGAZOVANA_PK" PRIMARY KEY ("REG_OZNAKA","ID_DEONICE") ENABLE;
 
 
--------------------------------------------------------

--------------------------------------------------------
--  Ref Constraints for Table GRADILISTE
--------------------------------------------------------

  ALTER TABLE "GRADILISTE" ADD CONSTRAINT "ID_PREDUZECE_GR_FK" FOREIGN KEY ("ID_PREDUZECE")
    REFERENCES "PREDUZECE" ("ID") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table IZVRSILAC
--------------------------------------------------------

  ALTER TABLE "IZVRSILAC" ADD CONSTRAINT "ID_RADNIK_FK" FOREIGN KEY ("ID_RADNIK")
    REFERENCES "RADNIK" ("ID_RADNIK") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table NADZORNIK
--------------------------------------------------------

  ALTER TABLE "NADZORNIK" ADD CONSTRAINT "ID_N_RADNIK_FK" FOREIGN KEY ("ID_RADNIK")
    REFERENCES "RADNIK" ("ID_RADNIK") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table RADNIK
--------------------------------------------------------

  ALTER TABLE "RADNIK" ADD CONSTRAINT "ID_PREDUZECE_FK" FOREIGN KEY ("ID_PREDUZECE")
    REFERENCES "PREDUZECE" ("ID") ENABLE;
	
  ALTER TABLE "RADNIK" ADD CONSTRAINT "ID_S_RADNIK_FK" FOREIGN KEY ("ID_NADREDJENI")
    REFERENCES "RADNIK" ("ID_RADNIK") ENABLE;
	

--------------------------------------------------------
--  Ref Constraints for Table PUTNICKO
--------------------------------------------------------

  ALTER TABLE "PUTNICKO" ADD CONSTRAINT "REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "VOZILO" ("REG_OZNAKA") ENABLE;

---------=----------------------------------------------
--  Ref Constraints for Table TERETNO
--------------------------------------------------------

  ALTER TABLE "TERETNO" ADD CONSTRAINT "T_REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "VOZILO" ("REG_OZNAKA") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table RADNA_MASINA
--------------------------------------------------------

  ALTER TABLE "RADNA_MASINA" ADD CONSTRAINT "RM_REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "VOZILO" ("REG_OZNAKA") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table SPOLJNI_SARADNIK
--------------------------------------------------------

  ALTER TABLE "SPOLJNI_SARADNIK" ADD CONSTRAINT "ID_NADZORNIKA_FK" FOREIGN KEY ("ID_NADZORNIKA")
    REFERENCES "NADZORNIK" ("ID_RADNIK") ENABLE;
 
--------------------------------------------------------
--  Ref Constraints for Table DEONICA
--------------------------------------------------------

  ALTER TABLE "DEONICA" ADD CONSTRAINT "D_ID_GRADILISTA_FK" FOREIGN KEY ("ID_GRADILISTA")
    REFERENCES "GRADILISTE" ("ID_GRADILISTA") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table DUZI
--------------------------------------------------------

  ALTER TABLE "DUZI" ADD CONSTRAINT "DUZI_ID_RADNIK_FK" FOREIGN KEY ("ID_RADNIK")
    REFERENCES "NADZORNIK" ("ID_RADNIK") ENABLE;
 
  ALTER TABLE "DUZI" ADD CONSTRAINT "DUZI_REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "PUTNICKO" ("REG_OZNAKA") ENABLE;
	
--------------------------------------------------------
--  Ref Constraints for Table UPRAVLJA !!!!!!!! DODATO !!!!!!
--------------------------------------------------------

  ALTER TABLE "UPRAVLJA" ADD CONSTRAINT "UPRAVLJA_ID_RADNIK_FK" FOREIGN KEY ("ID_RADNIK")
    REFERENCES "IZVRSILAC" ("ID_RADNIK") ENABLE;
 
  ALTER TABLE "UPRAVLJA" ADD CONSTRAINT "UPRAVLJA_REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "VOZILO" ("REG_OZNAKA") ENABLE;
	
--------------------------------------------------------
--  Ref Constraints for Table RADI_NA
--------------------------------------------------------

  ALTER TABLE "RADI_NA" ADD CONSTRAINT "RADI_ID_RADNIK_FK" FOREIGN KEY ("ID_RADNIK")
    REFERENCES "IZVRSILAC" ("ID_RADNIK") ENABLE;
 
  ALTER TABLE "RADI_NA" ADD CONSTRAINT "RADI_ID_DEONICE_FK" FOREIGN KEY ("ID_DEONICE")
    REFERENCES "DEONICA" ("ID_DEONICE") ENABLE;

--------------------------------------------------------
--  Ref Constraints for Table TERETNO_ANGAZOVANO
--------------------------------------------------------

  ALTER TABLE "TERETNO_ANGAZOVANO" ADD CONSTRAINT "TER_ANG_ID_DEONICE_FK" FOREIGN KEY ("ID_DEONICE")
    REFERENCES "DEONICA" ("ID_DEONICE") ENABLE;
 
  ALTER TABLE "TERETNO_ANGAZOVANO" ADD CONSTRAINT "TER_ANG_REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "TERETNO" ("REG_OZNAKA") ENABLE;


--------------------------------------------------------
--  Ref Constraints for Table RADMAS_ANGAZOVANA
--------------------------------------------------------

  ALTER TABLE "RADMAS_ANGAZOVANA" ADD CONSTRAINT "RADMAS_ANG_ID_DEONICE_FK" FOREIGN KEY ("ID_DEONICE")
    REFERENCES "DEONICA" ("ID_DEONICE") ENABLE;
 
  ALTER TABLE "RADMAS_ANGAZOVANA" ADD CONSTRAINT "RADMAS_ANG_REG_OZNAKA_FK" FOREIGN KEY ("REG_OZNAKA")
    REFERENCES "RADNA_MASINA" ("REG_OZNAKA") ENABLE;


--------------------------------------------------------
--------------------------------------------------------
-----------------------TRIGGERS---==--------------------
--------------------------------------------------------
--------------------------------------------------------


--------------------------------------------------------
--  DDL for Trigger RADNIK_AUTO_PK
--------------------------------------------------------

CREATE OR REPLACE TRIGGER "RADNIK_AUTO_PK" 
  BEFORE INSERT ON RADNIK 
  REFERENCING NEW AS NEW 
  FOR EACH ROW
  BEGIN
    SELECT ID_RADNIK_SEQ.NEXTVAL INTO :NEW.ID_RADNIK FROM DUAL;
  END;
/
ALTER TRIGGER "RADNIK_AUTO_PK" ENABLE;



--------------------------------------------------------
--  DDL for Trigger PREDUZECE_AUTO_PK
--------------------------------------------------------

CREATE OR REPLACE TRIGGER "PREDUZECE_AUTO_PK" 
  BEFORE INSERT ON PREDUZECE 
  REFERENCING NEW AS NEW 
  FOR EACH ROW
  BEGIN
    SELECT ID_PREDUZECE_SEQ.NEXTVAL INTO :NEW.ID FROM DUAL;
  END;
/
ALTER TRIGGER "PREDUZECE_AUTO_PK" ENABLE;


--------------------------------------------------------
--  DDL for Trigger GRADILISTE_AUTO_PK
--------------------------------------------------------

CREATE OR REPLACE TRIGGER "GRADILISTE_AUTO_PK" 
  BEFORE INSERT ON GRADILISTE 
  REFERENCING NEW AS NEW 
  FOR EACH ROW
  BEGIN
    SELECT ID_GRADILISTE_SEQ.NEXTVAL INTO :NEW.ID_GRADILISTA FROM DUAL;
  END;
/
ALTER TRIGGER "GRADILISTE_AUTO_PK" ENABLE;


--------------------------------------------------------
--  DDL for Trigger DEONICA_AUTO_PK
--------------------------------------------------------

CREATE OR REPLACE TRIGGER "DEONICA_AUTO_PK" 
  BEFORE INSERT ON DEONICA
  REFERENCING NEW AS NEW 
  FOR EACH ROW
  BEGIN
    SELECT ID_DEONICE_SEQ.NEXTVAL INTO :NEW.ID_DEONICE FROM DUAL;
  END;
/
ALTER TRIGGER "DEONICA_AUTO_PK" ENABLE;


--------------------------------------------------------
--  DDL for Trigger BROJ_UGOVORA_O_DELU_AUTO_PK
--------------------------------------------------------
 
CREATE OR REPLACE TRIGGER "BROJ_UGOVORA_O_DELU_AUTO_PK" 
  BEFORE INSERT ON SPOLJNI_SARADNIK
  REFERENCING NEW AS NEW 
  FOR EACH ROW
  BEGIN
    SELECT BROJ_UGOVORA_O_DELU_SEQ.NEXTVAL INTO :NEW.BROJ_UGOVORA_O_DELU FROM DUAL;
  END;
  /
ALTER TRIGGER "BROJ_UGOVORA_O_DELU_AUTO_PK" ENABLE;

