/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Base de datos para Entrada CICE */
/****************************************************/
/*
 *	drop database library_check_in
 *	create database library_check_in;
 *
*/

use library_check_in2;

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Licenciatura 					*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   07-02-2018                      */
/*  Change		|   Tipo de dato para fecha 		*/
/****************************************************/
create table career(
	id integer primary key not null identity,			/*id incremental*/
	career_name varchar(250) not null,					/*Nombre de la licenciatura*/
	career_key varchar(6) not null,						/*Clave de la licenciatura*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
);

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Estudiante  					*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   07-02-2018                      */
/*  Change		|   Tipo de dato para fecha 		*/
/****************************************************/
create table student(
	id integer primary key not null identity,			/*id incremental*/
	number varchar(7) not null,							/*Matricula del estudiante*/
	student_name varchar(50) not null,					/*Nombre */
	student_father_last_name varchar(50) not null,		/*Apellido Paterno*/
	student_mother_last_name varchar(50),				/*Apellido Materno*/
	semester int not null,								/*Semestre*/
	id_career int not null,								/*Lave foranea a la licenciatura(career)*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
	foreign key (id_career) references career(id)
);


/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Tipo de persona que no es 		*/
/*					estudiante 						*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   07-02-2018                      */
/*  Change		|   Tipo de dato para fecha 		*/
/****************************************************/
create table type_not_student(
	id integer primary key not null identity,			/*id incremental*/
	description varchar(250) not null,					/*Descripción de tipo*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
);

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Persona que no es Estudiante 	*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   07-02-2018                      */
/*  Change		|   Tipo de dato para fecha 		*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   23-02-2018                      */
/*  Change		|   Se agregó el campo de numero 	*/
/****************************************************/
create table not_student(
	id integer primary key not null identity,			/*id incremental*/
	number varchar(7) not null,							/*Número del no estudiante*/
	name varchar(50) not null,							/*Nombre*/
	father_last_name varchar(50) not null,				/*Apellido Paterno*/
	mother_last_name varchar(50),						/*Apellido Materno*/
	id_type_not_student int not null,					/*Tipo de no estudiante*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
	foreign key (id_type_not_student) references type_not_student(id)
);

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Tipo de usuario para la 		*/
/*					aplicación						*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   07-02-2018                      */
/*  Change		|   Tipo de dato para fecha 		*/
/****************************************************/
create table type_user(
	id integer primary key not null identity,			/*id incremental*/
	description varchar(250) not null,					/*Descripción de tipo*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
);

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   02-02-2018                      */
/*  Description |   Usuario para la aplicación		*/
/****************************************************/
/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   07-02-2018                      */
/*  Change		|   Tipo de dato para fecha 		*/
/****************************************************/
create table user_CICE(
	id integer primary key not null identity,			/*id incremental*/
	user_name varchar(50) not null,						/*Nombre*/
	user_password varchar(50) not null,					/*Contraseña de usuario*/
	father_last_name varchar(50) not null,				/*Apellido Paterno*/
	mother_last_name varchar(50),						/*Apellido Materno*/
	id_type_user int not null,							/*Tipo de no estudiante*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
	foreign key(id_type_user) references type_user(id)
);

/****************************************************/
/*  Author      |   Arcelia Aguirre                 */
/*  Date        |   15-03-2018                      */
/*  Change		|   Entrada a la biblioteca 		*/
/****************************************************/
create table access(
	id integer primary key not null identity,			/*id incremental*/
	id_student int,							/*Estudiante que ingresa*/
	id_not_student int,						/*No estudiante que ingresa*/
	created_at datetime default getdate() not null,		/*Fecha de creación del registro*/
	updated_at datetime default getdate() not null,		/*Fecha de ultima modificación*/
	active bit default 1								/*Registro activo*/
	foreign key(id_student) references student(id),
	foreign key(id_not_student) references not_student(id)
);