/********************************************************************/
/*  Author      |   Arcelia Aguirre Treviño							*/
/*  Date        |   23-02-2018										*/
/*  Description	|   Consulta de Licenciaturas	 					*/
/*  Name		|   career_consult				 					*/
/*  Parameters	|   @id int not null								*/
/*					@career_name varchar(250)not null				*/
/*					@career_key varchar(6) not null					*/
/*					@type_consult varchar(2) not null				*/
/*  Call		|   career_consult @id = 0, @career_name = '',		*/
/*					@career_key = '', @type_consult = ''			*/
/********************************************************************/
create procedure career_consult @id int, @career_name varchar(250), @career_key varchar(6), @type_consult varchar(2)
as
begin
    declare @LIST_L1 varchar(2)			= 'L1';
    declare @LIST_L2 varchar(2)			= 'L2';
    declare @CONSULT_L1 varchar(2)		= 'C1';
    declare @CONSTANT_LIKE varchar(1)	= '%';

    set @career_name = ltrim(rtrim(@career_name));
	set @career_key = ltrim(rtrim(@career_key));

    if @type_consult = @LIST_L1 
	begin
        select id as id_career, career_name, career_key
        from career
        where active = 1;
        return;
    end 
    
    if @type_consult = @LIST_L2 
    begin
        select id as id_career, career_name, career_key
        from career
        where active = 1 and
            career_name like @CONSTANT_LIKE + @career_name + @CONSTANT_LIKE;
        return;
    end     
    
     if @type_consult = @CONSULT_L1
    begin
        select id, career_name, career_key
        from career
        where active = 1 and
            id = @id;
        return;
    end
end