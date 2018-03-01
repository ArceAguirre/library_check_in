/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   20-02-2018										*/
/*  Description	|   Baja Lógica de estudiantes						*/
/*  Name		|   student_delete					 				*/
/*  Parameters	|   @id int	not null								*/
/*  Call		|   student_delete @id int							*/
/********************************************************************/
create procedure student_delete @id int
as
begin
	declare @var_id int;
	select @var_id = id from not_student where id = @id and active = 1;
	
	if @var_id = '' or @var_id = null or @var_id is null or @var_id = 0
	begin
    	select 
            '001' as error,
            'No existe el no estudiante' as error_message;
        return;
	end
		update student set 
			active = 0
		where id = @var_id;
		
		select 
			'000' as error,
			'Correcto' as error_message;
end;