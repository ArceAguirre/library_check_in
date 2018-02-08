/********************************************************************/
/*  Author      |   Arcelia Aguirre									*/
/*  Date        |   07-02-2018										*/
/*  Description	|   Alta de Licenciaturas	 						*/
/*  Name		|   career_new				 						*/
/*  Parameters	|   @career_name varchar(250)not null				*/
/*					@career_key varchar(6) not null					*/
/*  Call		|   career_new @career_name = '', @career_key = ''	*/
/********************************************************************/

create procedure career_new @career_name varchar(250) not null, @career_key varchar(6) not null, 
as
begin
	declare @var_id integer;
	
	set @career_name = ltrim(rtrim(@career_name));
	set @career_key = ltrim(rtrim(@career_key));
	
	select  @var_id = 1|id
	from career 
	where career_key = @career_key;
	
	if EXISTS (@var_id)
	begin
		insert into career(career_name,career_key)
		values(@career_name, @career_key)
		
		select 
			'000' as error,
			'Correcto' as error_message; 
	end
end;
