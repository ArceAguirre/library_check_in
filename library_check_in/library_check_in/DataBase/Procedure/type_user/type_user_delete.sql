/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   20-02-2018										*/
/*  Description	|   Baja Lógica de tipo de usuario					*/
/*  Name		|   type_user							 			*/
/*  Parameters	|   @id int	not null								*/
/*  Call		|   type_user_delete @id int						*/
/********************************************************************/
create procedure type_user_delete @id int
as
begin
	declare @var_id int;
	select @var_id = 1|id from type_user where id = @id and active = 1;
	
	if @var_id = '' or @var_id = null or @var_id is null or @var_id = 0
	begin
    	select 
            '001' as error,
            'No existe el tipo de usuario' as error_message;
        return;
	end
		update type_user set 
			active = 0
		where id = @var_id;
		
		select 
			'000' as error,
			'Correcto' as error_message;
end;