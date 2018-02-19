/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   12-02-2018										*/
/*  Description	|   Alta de Tipos de usuario						*/
/*  Name		|   type_user_new						 			*/
/*  Parameters	|   @description varchar(250) not null				*/
/*  Call		|   type_user_new @description = ''					*/
/********************************************************************/
create procedure type_user_new @description varchar(250)
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
		insert into type_user(description)
		values(@description)
		
		select 
			'000' as error,
			'Correcto' as error_message;
			return	 
end;
