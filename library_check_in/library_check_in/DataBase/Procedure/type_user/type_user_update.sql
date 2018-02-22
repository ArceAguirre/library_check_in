/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   20-02-2018										*/
/*  Description	|   Modificacion de Tipos de usuario		 		*/
/*  Name		|   type_user						 				*/
/*  Parameters	|   @id int											*/
/*					@description varchar(250)						*/
/*  Call		|   type_user_update @id=0, @description = ''		*/
/********************************************************************/
create procedure type_user_update @id int, @description varchar(250)
as
begin
	declare @var_id integer;
	
	set @description = ltrim(rtrim(@description));
	
	select @var_id = 1|id from type_user where id = @id and active = 1;
	
	if @description = '' or @description = null or @description is null
	begin
    	select 
            '001' as error,
            'La descripción está vacia' as error_message;
        return
	end
	if @var_id = null or @var_id is null or @var_id = '' or @var_id = 0
	begin
		select 
			'002' as error,
			'El tipos de usuario no existe' as error_message;
		return;
	end
	
	update type_user set 
		description = @description, 
		updated_at = getdate()
	where id = @id;
	
	select 
		'000' as error,
		'Correcto' as error_message;
end;