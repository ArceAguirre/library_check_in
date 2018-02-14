/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   13-02-2018										*/
/*  Description	|   Baja Lógica de no estudiantes					*/
/*  Name		|   not_student_delete				 				*/
/*  Parameters	|   @id int	not null								*/
/*  Call		|   not_student_delete @id int						*/
/********************************************************************/
create procedure not_student_delete @id int
as
begin
	declare @var_id_not_student int;
	select @var_id_not_student = 1|id from not_student where id = @id and active = 1;
	
	if @var_id_not_student = '' or @var_id_not_student = null or @var_id_not_student is null or @var_id_not_student = 0
	begin
    	select 
            '001' as error,
            'No existe el no estudiante' as error_message;
        return;
	end
		update not_student set 
			active = 0
		where id = @var_id_not_student;
		
		select 
			'000' as error,
			'Correcto' as error_message;
end;