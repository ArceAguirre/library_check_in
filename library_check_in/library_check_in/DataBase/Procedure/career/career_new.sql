/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   07-02-2018										*/
/*  Description	|   Alta de Licenciaturas	 						*/
/*  Name		|   career_new				 						*/
/*  Parameters	|   @career_name varchar(250)not null				*/
/*					@career_key varchar(6) not null					*/
/*  Call		|   career_new @career_name = '', @career_key = ''	*/
/********************************************************************/
create procedure career_new @career_name varchar(250), @career_key varchar(6)
as
begin
	declare @var_key integer;
	
	set @career_name = ltrim(rtrim(@career_name));
	set @career_key = ltrim(rtrim(@career_key));
	
	select @var_key = 1|id from career where career_key = @career_key and active = 1;
	
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
	else
		insert into career(career_name,career_key)
		values(@career_name, @career_key)
		
		select 
			'000' as error,
			'Correcto' as error_message;
		return	 
end;

create procedure show_Types 
as
begin
	select descrition from type_user
end