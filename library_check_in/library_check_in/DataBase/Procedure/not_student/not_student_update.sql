/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   13-02-2018										*/
/*  Description	|   Modificación de no estudiantes					*/
/*  Name		|   not_student_update				 				*/
/*  Parameters	|   @id int	not null								*/
/*				|	@name varchar(50) not null						*/
/*				|	@father_last_name varchar(50) not null			*/
/*				|	@mother_last_name varchar(50)					*/
/*				|	@id_type_not_student int not null				*/
/*  Call		|   not_student_update @id = 0, @name = '',			*/
/*				|	@father_last_name='', @mother_last_name = '',	*/
/*				|	@id_type_not_student = 0						*/
/********************************************************************/
create procedure not_student_update @id int, @name varchar(50), @father_last_name varchar(50),
	@mother_last_name varchar(50), @id_type_not_student int
as
begin
	declare @var_id_type_not_student int;
	declare @var_id_not_student int;
	
	set @name = ltrim(rtrim(@name));
	set @father_last_name = ltrim(rtrim(@father_last_name));
	set @mother_last_name = ltrim(rtrim(@mother_last_name));
	
	select @var_id_type_not_student = 1|id from type_not_student where id = @id_type_not_student and active = 1;
	select @var_id_not_student = 1|id from not_student where id = @id and active = 1;
	
	if @name = '' or @name = null or @name is null
	begin
    	select 
            '001' as error,
            'El nombre está vacío' as error_message;
        return;
	end
	if @father_last_name = '' or @father_last_name = null or @father_last_name is null
	begin
    	select 
            '002' as error,
            'El apellido paterno está vacío' as error_message;
        return;
	end
	if @var_id_type_not_student = '' or @var_id_type_not_student = null or @var_id_type_not_student is null or @var_id_type_not_student = 0
	begin
    	select 
            '005' as error,
            'No existe el tipo de no estudiante' as error_message;
        return;
	end
	if @var_id_not_student = '' or @var_id_not_student = null or @var_id_not_student is null or @var_id_not_student = 0
	begin
    	select 
            '006' as error,
            'No existe el no estudiante' as error_message;
        return;
	end
		update not_student set 
			name = @name, 
			father_last_name = @father_last_name, 
			mother_last_name = @mother_last_name,
			id_type_not_student = @id_type_not_student,
			updated_at = getdate()
		where id = @var_id_not_student;
		
		select 
			'000' as error,
			'Correcto' as error_message;
end;