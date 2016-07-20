/*
Navicat PGSQL Data Transfer

Source Server         : LOCAL
Source Server Version : 90503
Source Host           : localhost:5432
Source Database       : ambita
Source Schema         : public

Target Server Type    : PGSQL
Target Server Version : 90503
File Encoding         : 65001

Date: 2016-07-19 21:42:41
*/


-- ----------------------------
-- Sequence structure for mascotas_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."mascotas_id_seq";
CREATE SEQUENCE "public"."mascotas_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 6
 CACHE 1;
SELECT setval('"public"."mascotas_id_seq"', 6, true);

-- ----------------------------
-- Sequence structure for razas_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."razas_id_seq";
CREATE SEQUENCE "public"."razas_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 1
 CACHE 1;
SELECT setval('"public"."razas_id_seq"', 1, true);

-- ----------------------------
-- Sequence structure for tiposmascotas_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."tiposmascotas_id_seq";
CREATE SEQUENCE "public"."tiposmascotas_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 3
 CACHE 1;
SELECT setval('"public"."tiposmascotas_id_seq"', 3, true);

-- ----------------------------
-- Sequence structure for usuarios_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."usuarios_id_seq";
CREATE SEQUENCE "public"."usuarios_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 3
 CACHE 1;
SELECT setval('"public"."usuarios_id_seq"', 3, true);

-- ----------------------------
-- Sequence structure for vacunas_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."vacunas_id_seq";
CREATE SEQUENCE "public"."vacunas_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 4
 CACHE 1;
SELECT setval('"public"."vacunas_id_seq"', 4, true);

-- ----------------------------
-- Sequence structure for vacunatorio_id_seq
-- ----------------------------
DROP SEQUENCE IF EXISTS "public"."vacunatorio_id_seq";
CREATE SEQUENCE "public"."vacunatorio_id_seq"
 INCREMENT 1
 MINVALUE 1
 MAXVALUE 9223372036854775807
 START 33
 CACHE 1;
SELECT setval('"public"."vacunatorio_id_seq"', 33, true);

-- ----------------------------
-- Table structure for clientes
-- ----------------------------
DROP TABLE IF EXISTS "public"."clientes";
CREATE TABLE "public"."clientes" (
"id" int8 DEFAULT nextval('usuarios_id_seq'::regclass) NOT NULL,
"username" varchar(40) COLLATE "default",
"password" varchar(255) COLLATE "default",
"nombres" varchar(255) COLLATE "default",
"apellido_p" varchar(255) COLLATE "default",
"apellido_m" varchar(255) COLLATE "default",
"telefono" varchar(255) COLLATE "default",
"celular" varchar(255) COLLATE "default",
"direccion" text COLLATE "default",
"idcomuna" int8,
"idregion" int8,
"avatar" text COLLATE "default",
"rut" varchar(255) COLLATE "default",
"fnacimiento" date
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of clientes
-- ----------------------------
INSERT INTO "public"."clientes" VALUES ('3', null, null, 'sebastian jorge', 'guajardo', 'acevedo', '55222222', '97853669', 'psje. parinacota #1346, Antofagasta', null, null, '20161971710518091_kanyx.jpg', '16438319-9', '1987-01-04');

-- ----------------------------
-- Table structure for mascotas
-- ----------------------------
DROP TABLE IF EXISTS "public"."mascotas";
CREATE TABLE "public"."mascotas" (
"id" int8 DEFAULT nextval('mascotas_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idclase" int8,
"idraza" int8,
"fnac" date,
"fadopcion" date,
"foto" text COLLATE "default",
"idadoptante" int8 DEFAULT 0 NOT NULL
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of mascotas
-- ----------------------------
INSERT INTO "public"."mascotas" VALUES ('1', 'princesa', '1', '1', '2016-02-18', null, '2016197104221111_kanyx.jpg', '0');
INSERT INTO "public"."mascotas" VALUES ('2', 'thor', '1', '1', '2016-07-19', null, '20161971058558601_kanyx.jpg', '0');
INSERT INTO "public"."mascotas" VALUES ('3', 'luna', '1', '1', '2016-07-19', null, '20161971059225051_kanyx.jpg', '0');
INSERT INTO "public"."mascotas" VALUES ('4', 'weed', '1', '1', '2016-07-06', null, '20161971157582921_kanyx.png', '0');
INSERT INTO "public"."mascotas" VALUES ('5', 'prueba', '1', '1', '2016-07-19', null, '20161971159228931_kanyx.png', '0');
INSERT INTO "public"."mascotas" VALUES ('6', 'verdejo', '1', '1', '2016-03-16', null, '20161971837333791_kanyx.png', '0');

-- ----------------------------
-- Table structure for razas
-- ----------------------------
DROP TABLE IF EXISTS "public"."razas";
CREATE TABLE "public"."razas" (
"id" int8 DEFAULT nextval('razas_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default",
"idtipo" int8
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of razas
-- ----------------------------
INSERT INTO "public"."razas" VALUES ('1', 'sin raza', '1');

-- ----------------------------
-- Table structure for tiposmascotas
-- ----------------------------
DROP TABLE IF EXISTS "public"."tiposmascotas";
CREATE TABLE "public"."tiposmascotas" (
"id" int8 DEFAULT nextval('tiposmascotas_id_seq'::regclass) NOT NULL,
"nombre" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of tiposmascotas
-- ----------------------------
INSERT INTO "public"."tiposmascotas" VALUES ('1', 'perro');
INSERT INTO "public"."tiposmascotas" VALUES ('2', 'gato');

-- ----------------------------
-- Table structure for usuarios
-- ----------------------------
DROP TABLE IF EXISTS "public"."usuarios";
CREATE TABLE "public"."usuarios" (
"id" int8 DEFAULT nextval('usuarios_id_seq'::regclass) NOT NULL,
"username" varchar(40) COLLATE "default" NOT NULL,
"password" varchar(255) COLLATE "default",
"nombres" varchar(255) COLLATE "default",
"apellido_p" varchar(255) COLLATE "default",
"apellido_m" varchar(255) COLLATE "default",
"telefono" varchar(255) COLLATE "default",
"celular" varchar(255) COLLATE "default",
"direccion" text COLLATE "default",
"idcomuna" int8,
"idregion" int8,
"avatar" text COLLATE "default",
"rut" varchar(255) COLLATE "default",
"fnacimiento" date
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of usuarios
-- ----------------------------
INSERT INTO "public"."usuarios" VALUES ('1', 'kanyx', 'da1b129b74fc3783351aa1b2fc9c7d22', 'sebastian jorge', 'guajardo', 'acevedo', '22222222', '999999999', 'pasaje parinacota 1346', '1', '2', null, '16438319-9', '1987-01-04');

-- ----------------------------
-- Table structure for vacunas
-- ----------------------------
DROP TABLE IF EXISTS "public"."vacunas";
CREATE TABLE "public"."vacunas" (
"id" int8 DEFAULT nextval('vacunas_id_seq'::regclass) NOT NULL,
"vacuna" varchar(255) COLLATE "default"
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of vacunas
-- ----------------------------
INSERT INTO "public"."vacunas" VALUES ('1', 'SEXTUPLE / OCUPLE 1°');
INSERT INTO "public"."vacunas" VALUES ('2', 'SEXTUPLE / OCUPLE 2°');
INSERT INTO "public"."vacunas" VALUES ('3', 'SEXTUPLE / OCUPLE 3°');
INSERT INTO "public"."vacunas" VALUES ('4', 'ANTIRABICA');

-- ----------------------------
-- Table structure for vacunatorio
-- ----------------------------
DROP TABLE IF EXISTS "public"."vacunatorio";
CREATE TABLE "public"."vacunatorio" (
"id" int8 DEFAULT nextval('vacunatorio_id_seq'::regclass) NOT NULL,
"idpet" int8,
"idvacuna" int2,
"fecha" date
)
WITH (OIDS=FALSE)

;

-- ----------------------------
-- Records of vacunatorio
-- ----------------------------
INSERT INTO "public"."vacunatorio" VALUES ('25', '5', '1', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('26', '5', '2', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('27', '5', '3', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('28', '5', '4', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('29', '3', '1', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('31', '3', '4', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('32', '6', '1', '2016-07-19');
INSERT INTO "public"."vacunatorio" VALUES ('33', '6', '2', '2016-07-19');

-- ----------------------------
-- View structure for vista_listamascotas
-- ----------------------------
CREATE OR REPLACE VIEW "public"."vista_listamascotas" AS 
 SELECT mascotas.id,
    mascotas.nombre,
    mascotas.idclase,
    mascotas.idraza,
    mascotas.fnac,
    mascotas.fadopcion,
    mascotas.foto,
    tiposmascotas.nombre AS tipo,
    razas.nombre AS raza
   FROM ((mascotas
     JOIN razas ON ((mascotas.idraza = razas.id)))
     JOIN tiposmascotas ON ((mascotas.idclase = tiposmascotas.id)));

-- ----------------------------
-- Alter Sequences Owned By 
-- ----------------------------
ALTER SEQUENCE "public"."mascotas_id_seq" OWNED BY "mascotas"."id";
ALTER SEQUENCE "public"."razas_id_seq" OWNED BY "razas"."id";
ALTER SEQUENCE "public"."tiposmascotas_id_seq" OWNED BY "tiposmascotas"."id";
ALTER SEQUENCE "public"."usuarios_id_seq" OWNED BY "usuarios"."id";
ALTER SEQUENCE "public"."vacunas_id_seq" OWNED BY "vacunas"."id";
ALTER SEQUENCE "public"."vacunatorio_id_seq" OWNED BY "vacunatorio"."id";

-- ----------------------------
-- Primary Key structure for table clientes
-- ----------------------------
ALTER TABLE "public"."clientes" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table mascotas
-- ----------------------------
ALTER TABLE "public"."mascotas" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table razas
-- ----------------------------
ALTER TABLE "public"."razas" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table tiposmascotas
-- ----------------------------
ALTER TABLE "public"."tiposmascotas" ADD PRIMARY KEY ("id");

-- ----------------------------
-- Primary Key structure for table usuarios
-- ----------------------------
ALTER TABLE "public"."usuarios" ADD PRIMARY KEY ("id", "username");

-- ----------------------------
-- Primary Key structure for table vacunatorio
-- ----------------------------
ALTER TABLE "public"."vacunatorio" ADD PRIMARY KEY ("id");
