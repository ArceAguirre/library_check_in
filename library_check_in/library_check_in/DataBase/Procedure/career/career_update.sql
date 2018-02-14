/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   09-02-2018										*/
/*  Description	|   Modificacion de Licenciaturas	 				*/
/*  Name		|   career_update				 					*/
/*  Parameters	|   @id int											*/
/*					@career_name varchar(250)						*/
/*					@career_key varchar(6)							*/
/*  Call		|   career_update @id = 0, @career_name = '',		*/
/*					@career_key = ''								*/
/********************************************************************/
create procedure career_update @id int, @career_name varchar(250), @career_key varchar(6)
as
begin
	declare @var_id integer;
	declare @var_key integer;
	
	set @career_name = ltrim(rtrim(@career_name));
	set @career_key = ltrim(rtrim(@career_key));
	
	select @var_id = 1|id from career where id = @id and active = 1;
	select  @var_key = 1|id from career where career_key = @career_key and id != @id and active = 1;
	
	if @career_name = '' or @career_name = null or @career_name is null
	begin
    	select 
            '001' as error,
            'El nombre está vacio' as error_message;
        return
	end
	if @career_key = '' or @career_key = null or @career_key is null
	begin
    	select 
            '002' as error,
            'La clave está vacia' as error_message;
        return
	end
	if @var_key != null or @var_key is not null or @var_key != '' or @var_key != 0
	begin
		select 
			'003' as error,
			'Clave ya existente' as error_message;
		return;
	end
	if @var_id = null or @var_id is null or @var_id = '' or @var_id = 0
	begin
		select 
			'004' as error,
			'La licenciatura no existe' as error_message;
		return;
	end
	
	update career set 
		career_name = @career_name, 
		career_key = @career_key,
		updated_at = getdate()
	where id = @id;
	
	select 
		'000' as error,
		'Correcto' as error_message;
end;