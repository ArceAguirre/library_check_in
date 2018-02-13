/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   12-02-2018										*/
/*  Description	|   Alta de estudiantes								*/
/*  Name		|   student_new						 				*/
/*  Parameters	|   @number varchar(7) not null						*/
/*					@student_name varchar(50) not null				*/
/*					@student_father_last_name varchar(50) not null	*/
/*					@student_mother_last_name varchar(50)			*/
/*					@semester int not null							*/
/*					@id_career int not null							*/
/*  Call		|   student_new @number = '', @student_name = '',	*/
/*					@student_father_last_name = '',					*/
/*					@student_mother_last_name = '', @semester = 0,	*/
/*					@id_career = 0									*/
/********************************************************************/
create procedure student_new @number varchar(7), @student_name varchar(50), @student_father_last_name varchar(50),
	@student_mother_last_name varchar(50), @semester int, @id_career int
as
begin
	declare @var_id_career int;
	
	set @number = ltrim(rtrim(@number));
	set @student_name = ltrim(rtrim(@student_name));
	set @student_father_last_name = ltrim(rtrim(@student_father_last_name));
	set @student_mother_last_name = ltrim(rtrim(@student_mother_last_name));
	
	select @var_id_career = 1|id from career where id = @id_career;
	
	if @number = '' or @number = null or @number is null
	begin
    	select 
            '001' as error,
            'La matr�cula est� vacia' as error_message;
            return
	end
	if @student_name = '' or @student_name = null or @student_name is null
	begin
    	select 
            '002' as error,
            'El nombre est� vac�o' as error_message;
            return
	end
	if @student_father_last_name = '' or @student_father_last_name = null or @student_father_last_name is null
	begin
    	select 
            '003' as error,
            'El apellido paterno est� vac�o' as error_message;
            return
	end
	if @semester < 1 or @semester > 11
	begin
    	select 
            '004' as error,
            'No es un semestre valido' as error_message;
            return
	end
	if @var_id_career = '' or @var_id_career = null or @var_id_career is null or @var_id_career = 0
	begin
    	select 
            '005' as error,
            'No existe la Licenciatura' as error_message;
            return
	end
		insert into student(number, student_name, student_father_last_name, student_mother_last_name, semester, id_career)
		values(@number, @student_name, @student_father_last_name, @student_mother_last_name, @semester, @id_career)
		
		select 
			'000' as error,
			'Correcto' as error_message;
			return
end;