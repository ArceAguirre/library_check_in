/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   12-02-2018										*/
/*  Description	|   Alta de no estudiantes							*/
/*  Name		|   not_student_new					 				*/
/*  Parameters	|   @name varchar(50) not null						*/
/*				|	@father_last_name varchar(50) not null			*/
/*				|	@mother_last_name varchar(50)					*/
/*				|	@id_type_not_student int not null				*/
/*  Call		|   not_student_new @name = '',@father_last_name='',*/
/*				|	@mother_last_name = '', @id_type_not_student = 0*/
/********************************************************************/
create procedure not_student_new @number varchar(7), @name varchar(50), @father_last_name varchar(50), @mother_last_name varchar(50), @id_type_not_student int
as
begin
	declare @var_id_type_not_student int;
	declare @var_number varchar(7);
	
	set @number = ltrim(rtrim(@number));
	set @name = ltrim(rtrim(@name));
	set @father_last_name = ltrim(rtrim(@father_last_name));
	set @mother_last_name = ltrim(rtrim(@mother_last_name));
	
	select @var_id_type_not_student = id from type_not_student where id = @id_type_not_student and active = 1;
	select @var_number = @number from not_student where number = @number and active = 1;
	
	if @number = '' or @number = null or @number is null
	begin
    	select 
            '001' as error,
            'El número está vacío' as error_message;
        return;
	end
	
	if @name = '' or @name = null or @name is null
	begin
    	select 
            '002' as error,
            'El nombre está vacío' as error_message;
        return;
	end
	if @father_last_name = '' or @father_last_name = null or @father_last_name is null
	begin
    	select 
            '003' as error,
            'El apellido paterno está vacío' as error_message;
        return;
	end
	if @var_id_type_not_student = '' or @var_id_type_not_student = null or @var_id_type_not_student is null or @var_id_type_not_student = 0
	begin
    	select 
            '004' as error,
            'No existe el tipo de no estudiante' as error_message;
        return;
	end
	
	if @var_number != '' or @var_number != null or @var_number is not null
	begin
    	select 
            '005' as error,
            'El número ya existe' as error_message;
        return;
	end
		insert into not_student(number, name, father_last_name, mother_last_name,id_type_not_student)
		values(@number, @name, @father_last_name, @mother_last_name, @id_type_not_student);
		
		select 
			'000' as error,
			'Correcto' as error_message;
end;