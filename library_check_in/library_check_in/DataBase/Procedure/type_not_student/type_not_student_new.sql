/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   12-02-2018										*/
/*  Description	|   Alta de Tipos de no estudiantes					*/
/*  Name		|   type_not_student_new				 			*/
/*  Parameters	|   @description varchar(250) not null				*/
/*  Call		|   type_not_student_new @description = ''			*/
/********************************************************************/
create procedure type_not_student_new @description varchar(250)
as
begin
	set @description = ltrim(rtrim(@description));
	
	if @description = '' or @description = null or @description is null
	begin
    	select 
            '001' as error,
            'El tipo está vacio' as error_message;
            return
	end
		insert into type_not_student(description)
		values(@description)
		
		select 
			'000' as error,
			'Correcto' as error_message;
			return	 
end;
