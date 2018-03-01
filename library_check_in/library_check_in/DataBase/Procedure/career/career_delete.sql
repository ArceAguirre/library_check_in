/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   13-02-2018										*/
/*  Description	|   Baja Lógica de Licenciaturas	 				*/
/*  Name		|   career_delete				 					*/
/*  Parameters	|   @id int											*/
/*  Call		|   career_delete @id = 0 							*/
/********************************************************************/
create procedure career_delete @id int
as
begin
	declare @var_id integer;
	
	select top 1 @var_id = id from career where id = @id and active = 1;
	
	if @var_id = null or @var_id is null or @var_id = '' or @var_id = 0
	begin
		select 
			'001' as error,
			'La licenciatura no existe' as error_message;
		return;
	end
	
	update career set 
		updated_at = getdate(),
		active = 0
	where id = @id;
	
	select 
		'000' as error,
		'Correcto' as error_message;
end;